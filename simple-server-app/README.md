# Simple Server App

Contains a server app for tests. Please ignore the solution name.
See changelog

>Status: debugging 🐌<br>
>Version: 0.5<br>
>Date released: 12/23/2025

## What does it do? - Purpose
Opens a window with only two button to simulate the behavior of a simple server.

## Content
Dependences: Service Model
Two buttons to simplify only.

## How does it work? - Behavior
The button "Send to server" is configured to access the localhost and sends some valid message:
  * The core is an Interface;
  * Uses a ServiceContract;
  * Uses two OperationContract;
  * A class inherits this Interface;
  * An instnace this class is created when triggers the event.
  * A messageBox returns the current state from the server. (WIP)

## What was used? - Resources
GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Windows Forms Framework| Framework v.4.7.2 | No  | Web service
