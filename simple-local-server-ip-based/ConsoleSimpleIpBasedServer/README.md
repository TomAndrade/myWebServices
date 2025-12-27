## Simple console IP based server (template)

### What does it do? - Purpose
Opens a console what simuilates a server.

### How does it work? - Behavior
* The console tries to simulate a server using the localhost itself.
* Requires a HTTP listener.
* Make sure the port used for localhost is available and accessible.
* The local server waits until a connection is established.
* The URL request requires one page at least: `switch(request.Url.AbsolutePath)`
* "dados" var means "data". Make sure the array size is within acceptable limits: `new byte[byte.MaxValue]`
* Since the data is entered programmatically, I decided not to include the "POST" method.

### What was used? - Resources
GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Console| Framework v.4.7.2 | No  | localhost
