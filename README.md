This program is to show join optimization, which has the ability to determine the order of joining two or more tables. In this implementation, we suppose the cost of executing each join is equal to the product of the number of rows in the first table multiplied by the ceiling divided by the number of rows in the second table by 20, i.e.

cost(i,j)=No. of rows of T_i *⌈((No. of rows of T_j)/20)⌉.

Also, we suppose that when we join two tables together, the result will be a new temporary table whose number of rows is equal to the product of the number of rows of the two joined tables.

The input of the program is the total number of tables and the number of rows in each table.

The program works for each input and finally determines the order of the joins and transfers this order to the output along with the total cost.
