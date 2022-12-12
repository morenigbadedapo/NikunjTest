Feature: FacebookMarketPlaceRegistration
	//Simple Signup for https://angularjs.realworl.io

@mytag
Scenario: Valid Registration
	Given I Navigate to the Website
	And I click on Sign Up
	And I type in Username
	And I type in Email
	And I typed in Password
	When the Sign Up Button is clicked
	#Then I should be able to sign up successfully