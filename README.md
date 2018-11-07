# OpenClosedExample

Demonstrate how a programmer might use typical OOP to solve concrete problems with composable code.

To test the code, run it and try some of these url's:
- /api/move/train/10
- /api/move/jet/2
- /api/move/hippo/13

New "MoveProcessor" implementations can be added to the system without modifying any code.  This makes the code Closed to modification and Open to extension.

To extend the program to add a new behavior, create a new concrete implementation and then register it in your IoC container to make the type available.

There are several benefits to using this sort of pattern over other alternatives:

1.  Your business logic is contained is a small, specific, easy-to-test unit.
1.  You can add new capabilities without affecting other code, perhaps introducing unintended side-effects.
1. Maintenance is much easier since the the surface area to debug is significantly smaller.
