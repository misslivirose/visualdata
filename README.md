# visualdata

A WebVR ASP.NET app to visualize Excel chart data as 3D, human-scaled environments.

4/1 Developer Notes:
- Added WebGL canvas function, file uploader element
- TODO: Fix bug where WebGL canvas is disappearing after function finishes
      Note: fixed with a return false to prevent postback
- TODO: Enable cloud storage to store the document uploaded so it can be manipulated in the helper C# classes to create a JSON object based on the data from the .xlsx file
- TODO: Investigate why Promise is throwing exception on IE11

4/7 Developer Notes:
- A basic navigation system in place 
