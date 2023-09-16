Feature: Loan


@mytag
Scenario: Check that the phone number passes the form validation.
	Given user is on monevo page
	When user enter loan amount '1,000'
	And user select duration '1 year'
	And user select what to use the loan for
	And user select title
	And user enters firstname 'Owen' and lastname 'wdwWWRVDAD'
	And user enter date of birth '10/02/1978' 
	And user enter email 'sosolisso147@gmail.com' 
	And user enter phone number '07897641544'
	Then phone number passes form validation and whats your marital status is displayed


@mytag
Scenario: Check that the phone number fails the form validation.
	Given user is on monevo page
	When user enter loan amount '1,000'
	And user select duration '1 year'
	And user select what to use the loan for
	And user select title
	And user enters firstname 'Owen' and lastname 'wdwWWRVDAD'
	And user enter date of birth '10/02/1978' 
	And user enter email 'sosolisso147@gmail.com' 
	And user enter phone number '310-323-258'
	Then error message is displayed