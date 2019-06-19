Hi! 

This is a classical Game of Life game invited by John Conway. 

<img src="/Skjermbilde.png?raw=true" width="320"/>

A living cell is blue. It survives only when surrounded by two other cells. A new cell is born if surrounded by three cells. Every cell dies when it is has less or more neighbours.

Please, use the mouse to build any lifeform that you like! You can add more cells while the evolution is running :) 
- *Fase One* - highlights the cells that are dying(red), newborn(green) and survived(blue).

- *Fase Two* - finishes the turn with removing dead cells and establishing newborn and survived cells. 

- *Proceed fases* - combines both fases in one step. 

- *Contaminate* - randomly fills the field with live cells. 

- *Clear* - clears the field. The field is resizable and every change of sizes clears the field. 

- *Timer* - starts the Life game until stopped. 

The game was programmed as an array of labels. The mathematical model is based on subtraction. 
The program sums number of cells that are placed in the rectangle, which sides are: 
- distance from the cell to the right edge, and 
- distance from the cell to the bottom edge of field.

Rectangles are built for every cell and calculated. 
Then, from the sum of the selected cell substracts sum of closest cells that are to the right and down from it.    

Have fun!