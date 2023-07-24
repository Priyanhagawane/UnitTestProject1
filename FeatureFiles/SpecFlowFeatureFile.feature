@SpecFlowFeatureFile
Feature: SpecFlowFeatureFile



Background: 
    Given Launch the InfoFlex
	When User login


Scenario: As a user I want to see Home Page of the Design Management
	Given traverse through the module to open Design Management
	And I need to click Design Management module
	Then Home Page of the Design Management should be opened

Scenario: As a user I want to click Design Management
	Given click Design Management
	When click on Design Management New window should be opened




