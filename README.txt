Solution 1 Time complexity:
O(ordersCount + cashierCount) seconds.
Example: In case of 100 orders in line and 5 cashier, it will take 105 seconds to proccess these orders.

Solution 1 Space complexity:
O(cashierCount) => There are always cashierCount items in the queue.

Solution 2 Time Complexity:
O(1). Explanation: I am using a dictionary to store the sorted strings and for each sorted string i store
a list of matched string(letter order does not matter). 
To search a string, first i need to sort the input string(O(1) since the string length is constant in our case), 
then i need to look it up in a dictionary(which is O(1) operation), therefore, the total time complexity is O(1).

Solution 2 Space Complexity:
O(string list length * string length(5)). Explanation: The dictionary keys contain 1 milion strings and the values
contains minimum of 1 milion strings(in case there is just 1 permutation) or 120 milion strings(in case there's maximum 
amount of 5 permutation strings