
Feature: BloodPressure

Scenario: Calculate a Low BMI
	Given the Systolic number is 80
	And the Diastolic number is 50
	When the blood pressure is calculated
	Then the result should be Low

Scenario: Calculate a Ideal BMI
	Given the Systolic number is 110
	And the Diastolic number is 70
	When the blood pressure is calculated
	Then the result should be Ideal

Scenario: Calculate a PreHigh BMI
	Given the Systolic number is 139
	And the Diastolic number is 90
	When the blood pressure is calculated
	Then the result should be PreHigh 

Scenario: Calculate a High BMI
	Given the Systolic number is 140
	And the Diastolic number is 90
	When the blood pressure is calculated
	Then the result should be High
