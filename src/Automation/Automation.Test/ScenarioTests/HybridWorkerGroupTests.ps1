﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

# Automation account information
$resourceGroupName = "to-delete-01"
$automationAccountName = "fbs-aa-01"
$hybridWorkerGroupName = "hw-grp3"

function Test-E2EHybridWorkerGroup
{
    $expectedHybridWorkerGroup = @{
        ResourceGroupName = $resourceGroupName
        AutomationAccountName = $automationAccountName
        Name = $hybridWorkerGroupName
        GroupType = "User"
    }

    New-AzAutomationHybridRunbookWorkerGroup  -ResourceGroupName $resourceGroupName `
                                              -AutomationAccountName $automationAccountName  `
                                              -Name $hybridWorkerGroupName  `
                                              -ErrorAction SilentlyContinue

    $group = Get-AzAutomationHybridRunbookWorkerGroup -ResourceGroupName $resourceGroupName `
                                                     -AutomationAccountName $automationAccountName  `
                                                     -Name $hybridWorkerGroupName 

    # Validate the hybrid worker group properties
    $propertiesToValidate = @("GroupType")

    Assert-AreEqual $group.name $expectedHybridWorkerGroup.Name
    foreach ($property in $propertiesToValidate)
    {
        Assert-AreEqual $group.$property $expectedHybridWorkerGroup.$property `
            "'$property' of hybrid worker group does not match. Expected:$($expectedHybridWorkerGroup.$property) Actual: $($group.$property)"
    }

	# Remove the HybridWorkerGroup
	Remove-AzAutomationHybridRunbookWorkerGroup -ResourceGroupName $resourceGroupName `
                                              -AutomationAccountName $automationAccountName  `
                                              -Name $hybridWorkerGroupName
	
	# Make sure it was the hybrid worker group was deleted
	$group = Get-AzAutomationHybridRunbookWorkerGroup -ResourceGroupName $resourceGroupName `
                                              -AutomationAccountName $automationAccountName  `
                                              -Name $hybridWorkerGroupName `
                                              -ErrorAction SilentlyContinue

    Assert-True {$group -eq $null} "Fail to remove HybridWorkerGroup '$hybridWorkerGroupName'"
}

