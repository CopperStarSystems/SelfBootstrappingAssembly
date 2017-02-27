# SelfBootstrappingAssembly
A simple example of using Castle Windsor within a .dll without forcing consumers to take a dependency on Windsor.

## Console Application:
The console application does not have a dependency on Castle Windsor, and does not use the container directly.

## ExternalDependency:
ExternalDependency represents an external library that uses Castle Windsor internally for inversion of control.  Logically, the entry point is in the ExternalDependencyFactory's Create method.
In the Create method, we bootstrap the container using Windsor's Installer framework, then we use the container to resolve the root dependency and return it to the calling application.
