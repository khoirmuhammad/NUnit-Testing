# NUnit-Testing
Perform testing using NUnit Framework in ASP.NET Core

## Introduction
1. Install NUnit package
2. Install NUnit3TestAdapter package
3. Install Microsoft.NET.Test.Sdk package

Notes : NUnit (In order to use several features of NUnit such as its function, attribute etc), wheares NUnit3TestAdapter & Microsoft.NET.Test.Sdk package (In order to integrate between NUnit and Visual Studio)

## Web Application
Here we only create simple Interface and Class that used to procees string input. For right now we only have one function called ReverseString.

## NUnit Test Project
1. TestFixture : attribute for class, therfore the class can be recognized by NUnit Testing
2. SetUp : attribute for method. It used to set up the configuration such connection string, instance object creation etc. Methotd belongs to Setup attrubute will be invoked every time the Method Test are called.
3. Test : attribute for method. Method needs to be tested will have this attribute
4. TestCase : attribute for method. Method needs to be tested will have this attribute
5. TestCaseSource : attribute for method. Method needs to be tested will have this attribute

We able to use one off the attribute for testing depending our preferency
