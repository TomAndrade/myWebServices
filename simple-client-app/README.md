# Simple Client App

Contains a client app for tests. Please ignore the solution name.

>Status: debugging 🐌<br>
>Version: not applicable<br>
>Date released: 12/25/2025 - _Merry Christmas!_

## What does it do? - Purpose
Opens a window with only one button to simulate the behavior of a client app.

## Content
Dependences: Service Reference (localhost)
One button to simplify.
One textBox and one MessageBox to be receivers.

## How does it work? - Behavior
The button "Get from server" is configured to access the server and receive some valid messages from it:
  * The core is an InterfaceServerClient;
  * The textBox receives a response from server;
  * A MessageBox appears when there is a response.

## What was used? - Resources
GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Windows Forms| v.8.0 | No  | Web service/ localhost
