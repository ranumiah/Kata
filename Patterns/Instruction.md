Raise Me to The Third Power, Search My Divisors... .....Could You Believe that?

30093% of 1511 of 108raulbc777
C#TRAINNEXT KATA
Details
Solutions
Discourse (25)
Add to Collection|Share this kata:
Description:

The number six has this interesting property, and is the smallest number in having it (after the integer 1 that obviously fulfills this condition): Its cube, is divisible by the sum of its divisors. Let's see it:

6 ^ 3 = 216
divisors of 6: 1, 2, 3, 6
sum of its divisors= 1 + 2 + 3 + 6 = 12
And 216 / 12 = 18 (integer) and 18.12 = 216
The first terms of this sequence are:

n    a(n)
1       6 
2      28
3      30
4      84
5     102
Your challenge is to create a function int_cube_sum_div() (or similar in other languages), that may receive, n, the ordinal number of the term of the sequence, as an argument, and outputs the corresponding value of the term of that sequece of integers. Or explained in this way:

int_cube_sum_div(n) -------> a(n)
Let's see some cases:

int_cube_sum_div(4) ------> 84
/// divisors of 84 : 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84
    sum of divisors = 1 + 2 + 3 + 4 + 6 + 7 + 12 + 14 + 21 + 28 + 42 + 84 = 224
    cube of 84 = 84^3 = 592704
    592704 is a multiple of 224///

int_cube_sum_div(5) ------> 102
Your code should use memoization in order to have higher speed for testing. Does your code reach up to the 120-th term? We can get this upper limit in the tests.

Enjoy it and happy coding!!











6 kyu
Find the First Number in Having a Certain Number of Divisors I

33093% of 2036 of 151raulbc777
C#TRAINNEXT KATA
Details
Solutions
Discourse (25)
Add to Collection|Share this kata:
Description:

The number 12 is the first number in having six divisors, they are: 1, 2, 3, 4, 6 and 12. Your challenge for this kata is to find the minimum number that has a certain number of divisors. For this purpose we have to create the function

find_min_num() or findMinNum() or similar in the other languages

that receives the wanted number of divisors num_div, and outputs the smallest number having an amount of divisors equals to num_div.

Let's see some cases:

find_min_num(10) = 48 # divisors are: 1, 2, 3, 4, 6, 8, 12, 16, 24 and  48
find_min_num(12) = 60
In this kata all the tests will be with numDiv < 80

(There will be a next kata with numDiv < 10000, Find the First Number Having a Certain Number of Divisors II, should have the help of number theory)

Enjoy it and happy coding! (Memoization is advisable)