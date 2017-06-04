# Invisionware Framework
Invisionware Frmaework is a collection of utilities classes, extension methods, and new functionality to simplify creatig application in .NET. Amost all of the libraries are support on Dektop and Mobile (including Xamarin) development environments to provide the maxinum value possible.

## Threading
This portion of the Invisionware Framework is focused on enhancements to Threading in the .NET frmaework.

Add the following using statement
```c#
using Invisionware.Threading;
```

### TaskLocal<T>

**See Unit Tests for Examples**

### AsyncLocal<TImmutableType> 
*Note: Only support on .NET 4.5+ Desktop*

### AwaitableDisposable<T>
An awaitable wrapper around a task whose result is disposable. The wrapper is not disposable, so this prevents usage errors like "using (MyAsync())" when the appropriate usage should be "using (await MyAsync())".
Copied from https://github.com/StephenCleary/AsyncEx.Coordination/blob/master/src/Nito.AsyncEx.Coordination/AwaitableDisposable.cs
