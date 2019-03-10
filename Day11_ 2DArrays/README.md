# README

## Notes
The hourglass can be considered as 7 coordinates in the grid
```
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
``` 
Considering the first hourglass
```
1 1 1
  1  
1 1 1
```
As being made up of the coordinates
`(0, 0), (0, 1), (0, 2), (1, 1), (2, 0), (2, 1), (2, 2)`

Or with variables
```
x = 0  // x-axis
y = 0  // y-axis

(y, x), (y, x + 1), (y, x + 2), (y + 1, x + 1), (y + 2, x), (y + 2, x + 1), (y + 2, x + 2)
```

Now to reference the next hourglass, we increment x by 1 while x is less than the length minus 2

When the above condition is met; move down to the next row. That is y + 1 while y is less than the
length minus 2
