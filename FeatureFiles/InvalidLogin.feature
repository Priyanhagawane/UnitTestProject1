@InvalidLogin
Feature: InvalidLogin



Scenario: As a user I want to see Invalid Login message
	Given Launch the InfoFLex Web
	When Login with Invalid Username
	When Login with Invalid Password
	Then Login with Invalid Username and Password