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