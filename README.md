# hng12-stage-0

## Overview
This is a simple public API built with **.NET 8** that returns basic information, including:
- The registered email address for HNG12 Slack workspace.
- The current date and time in **ISO 8601** format.
- The GitHub URL of the project codebase.

## Tech Stack
- **Framework:** .NET 8 
- **Hosting Platform:** Render
- **Version Control:** Git & GitHub

## API Documentation
### **Endpoint:**
```
GET https://hng12-stage-0-it2d.onrender.com
```

### **Response Format (200 OK):**
```json
{
  "email": "your-email@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/adebisi4145/hng12-stage-0"
}
```

## Setup Instructions
### **Prerequisites**
- .NET 8 SDK installed
- Git installed

### **Clone the Repository**
```sh
git clone https://github.com/adebisi4145/hng12-stage-0.git
cd hng12-stage-0
```

### **Run Locally**
```sh
dotnet run
```

## References
- Learn more about C# developers: [HNG C# Developers](https://hng.tech/hire/csharp-developers)


