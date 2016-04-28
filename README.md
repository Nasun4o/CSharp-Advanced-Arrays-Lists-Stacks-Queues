# CSharp-Advanced-Arrays-Lists-Stacks-Queues
Advanced CSharp

Problem 1.	Sort Array of Numbers
Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Examples:
Input	Output
6 5 4 10 -3 120 4	-3 4 4 5 6 10 120
10 9 8	8 9 10

Problem 2.	Sort Array of Numbers Using Selection Sort
Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.

Problem 3.	Categorize Numbers and Find Min / Max / Average
Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). Examples:
Input	Output
1.2 -4 5.00 12211 93.003 4 2.2	[1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
[-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00

Problem 4.	Sequences of Equal Strings
Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space. Examples:
Input	Output
hi yes yes yes bye	hi
yes yes yes
bye
SoftUni softUni softuni	SoftUni
softUni
softuni
1 1 2 2 3 3 4 4 5 5	1 1
2 2
3 3
4 4
5 5
a b b xxx c c c	a
b b
xxx
c c c
hi hi hi hi hi	hi hi hi hi hi
hello	hello

Problem 5.	Longest Increasing Sequence
Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them. Examples:
Input	Output
2 3 4 1 50 2 3 4 5	2 3 4
1 50
2 3 4 5
Longest: 2 3 4 5
8 9 9 9 -1 5 2 3	8 9
9
9
-1 5
2 3
Longest: 8 9
1 2 3 4 5 6 7 8 9	1 2 3 4 5 6 7 8 9
Longest: 1 2 3 4 5 6 7 8 9
5 -1 10 20 3 4	5
-1 10 20
3 4
Longest: -1 10 20
10 9 8 7 6 5 4 3 2 1	10
9
8
7
6
5
4
3
2
1
Longest: 10

Problem 6.	Subset Sums
Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets." Examples:
Input	Output
11
0 11 1 10 5 6 3 4 7 2	0 + 11 = 11
11 = 11
1 + 10 = 11
0 + 1 + 10 = 11
5 + 6 = 11
0 + 5 + 6 = 11
1 + 6 + 4 = 11
0 + 1 + 6 + 4 = 11
1 + 3 + 7 = 11
0 + 1 + 3 + 7 = 11
4 + 7 = 11
0 + 7 + 4 = 11
1 + 5 + 3 + 2 = 11
0 + 1 + 5 + 3 + 2 = 11
6 + 3 + 2 = 11
0 + 6 + 3 + 2 = 11
5 + 4 + 2 = 11
0 + 5 + 4 + 2 = 11
0
1 2 3 4 5	No matching subsets.
-2
-5 4 92 0 928 1 -1 4	-5 + 4 + -1 = -2
-5 + 4 + 0 + -1 = -2
Hint: Search how to generate subsets of elements with a bitwise mask.
