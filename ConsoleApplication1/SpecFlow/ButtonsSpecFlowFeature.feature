Feature: ButtonsSpecFlowFeature
	

@mytag
Scenario: Check if User able to Add a button
	Given Login to the MDT Portal
	And Create a button
	Then Close the driver
Scenario: Check if User able to Edit a button
	Given Login to the MDT Portal
	And Edit a button
	Then Close the driver
	Scenario: Check if User able to Delete a button
	Given Login to the MDT Portal
	And Delete a button
	Then Close the driver

	