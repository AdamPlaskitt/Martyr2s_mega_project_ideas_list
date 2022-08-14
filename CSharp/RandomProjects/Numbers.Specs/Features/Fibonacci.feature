Feature: Get Fibonacci element N

	Calculates the Fibonacci sequence to the Nth item.

Scenario Outline: Calculate the Nth item
	Given the target <n>
	When run
	Then the target is <output>

	Examples: 
	| n  | output |
	| 0  | 0      |
	| 1  | 1      |
	| 2  | 1      |
	| 3  | 2      |
	| 5  | 5      |
	| 11 | 89     |