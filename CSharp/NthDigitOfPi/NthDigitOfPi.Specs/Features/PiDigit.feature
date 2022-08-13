Feature: PiDigit

Simple command to calculate the Nth digit of PI.

Rule: Displays help.

	Scenario: No parameter given.
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

	Scenario Outline: Help parameter.
		Given the PiDigit command with the argument <argument>
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

Rule: States if the command is unknown.

	Scenario Outline: Unknown single argument.
		Given the PiDigit command with the argument <argument>
		When run
		Then the response is:
			"""
			Error - Unknown command, see 'PiDigit --help' for help
			"""

		Examples: 
		| argument    |
		| unknown     |
		| random case |

	Scenario Outline: Unknown arguments.
		Given the PiDigit command with the arguments '<argument1>' '<argument2>'
		When run
		Then the response is:
			"""
			Error - Unknown command, see 'PiDigit --help' for help
			"""

		Examples: 
		| argument1 | argument2 |
		| unknown   | test test |
		| random    | example   |

Rule: Invalid Nth digit to calculate.

	Scenario Outline: Asked to calculate negative digit.
		Given the PiDigit command with the argument <argument>
		When run
		Then the response is:
			"""
			Error - The Nth digit must be a positive integer
			"""

		Examples: 
		| argument |
		| -1       |
		| -53      |

	Scenario: Asked to calculate zeroth digit.
		Given the PiDigit command with the argument 0
		When run
		Then the response is:
			"""
			Error - The Nth digit must be a positive integer
			"""

	Scenario Outline: Asked to calculate decimal digit.
		Given the PiDigit command with the argument <argument>
		When run
		Then the response is:
			"""
			Error - The Nth digit must be a positive integer
			"""

		Examples: 
		| argument |
		| 0.4      |
		| 42.5     |

Rule: Calculate Nth digit of Pi.

	Scenario Outline: Asked to calculate digit.
		Given the PiDigit command with the argument <argument>
		When run
		Then the response is <answer>

		Examples: 
		| argument | answer |
		| 1        | 1      |
		| 2        | 4      |
		| 42       | 9      |
		| 420      | 3      |
