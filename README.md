# C#: OOP Tutorial

This is a simple tutorial about the main idea of OOP programming.

1. Create the base classes:
	*abstract class* **Vehicle**
	*class* **WheeledVehicle : Vehicle**
	*class* **FlyableVehicle : Vehicle**
2. Create classes, thath we will create objects of them:
	*class* **Car : WheeledVehicle**
	*class* **Bicycle : WheeledVehicle**
	*class* **Airplane : FlyableVehicle**
3. Create objects of this classes and a method with a parameter of type **Vehicle**
```csharp
void StartMoving(Vehicle movableThing)
{
	movableThing.Move();
}
```
4. Create *class* **Human** and create an object of it. If we try to pass it to *StartMoving(human)* we can't
5. Create *interface* **IMovable**
6. Implement it to **Vehicle** and **Human**
7. Change the parameter type in StartMoving and now we can call it with all the objects
```csharp
void StartMoving(IMovable movableThing)
{
	movableThing.Move();
}
```