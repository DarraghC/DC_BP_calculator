
Feature: BloodPressure

Scenario: Calculate a Low BloodPressure
	Given the Systolic number is 80
	And the Diastolic number is 50
	When the blood pressure is calculated
	Then the result should be Low

Scenario: Calculate a Ideal BloodPressure
	Given the Systolic number is 110
	And the Diastolic number is 70
	When the blood pressure is calculated
	Then the result should be Ideal

Scenario: Calculate a PreHigh BloodPressure
	Given the Systolic number is 139
	And the Diastolic number is 89
	When the blood pressure is calculated
	Then the result should be PreHigh 

Scenario: Calculate a High BloodPressure
	Given the Systolic number is 140
	And the Diastolic number is 90
	When the blood pressure is calculated
	Then the result should be High
