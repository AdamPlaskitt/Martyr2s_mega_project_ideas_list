Feature: PiDigit

Simple command to calculate the Nth digit of PI.


Rule: Displays help

	Scenario: 1. No parameter given
		Given the PiDigits command has no parameters
		When run
		Then the response is:
			"""
			NAME
				PiDigit

				Calculates and outputs the Nth digit of PI.

			SYNOPSIS
				PiDigit <N>
				PiDigit [-h, --help]

				<N>			Calculates Pi to the Nth digit
				-h, --help	Display help information
			"""


	Scenario Outline: 2. Help parameter
		Given the PiDigit command with <argument>
		When run
		Then the response is:
			"""
			NAME
				PiDigit

				Calculates and outputs the Nth digit of PI.

			SYNOPSIS
				PiDigit <N>
				PiDigit [-h, --help]

				<N>			Calculates Pi to the Nth digit
				-h, --help	Display help information
			"""

		Examples: 
		| argument |
		| -h       |
		| --help   |