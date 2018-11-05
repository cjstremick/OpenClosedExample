# OpenClosedExample

Demonstrate how a programmer might use typical OOP to solve concrete problems with composable code.

To test the code, run it and try some of these url's:
- /api/move/train/10
- /api/move/jet/2
- /api/move/hippo/13

New "MoveProcessor" implementations can be added to the system without modifying any code.  Simply 
create a new concrete implementation and register it in your IoC container to make the type available.

