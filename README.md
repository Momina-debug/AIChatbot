🤖  AI Assistant (.NET 8.0)A lightweight, 
high-performance desktop chatbot built with C# WinForms and powered by the Google
Gemini 2.5 Flash-Lite model. This project was developed as part of the Advanced Visual Programming course at KICSIT.
📊 Deep Analysis of System Architecture
The application is built on a Client-Server Architecture designed for low-latency interactions:
Asynchronous Processing: By utilizing the async/await pattern in C#, the UI remains fully responsive while the Gemini 2.5 model generates content.
Model Selection (2.5 Flash-Lite): Transitioning to the 2.5 Flash-Lite model was critical to overcoming the 429 Resource Exhausted quota errors found in older versions.
Contextual Intelligence: The model successfully recognizes the user's specific identity as a KICSIT student, providing tailored academic support.
🚀 Key FeaturesReal-time AI Interaction: 
Instant responses for study-related queries.Secure API Handling: Configuration is managed via App.config to prevent API key exposure.
Dockerized Deployment:
Fully containerized for consistent behavior across different environments.
🛠️ Tools & TechnologiesFramework:
.NET 8.0 (LTS)Library: Google.GenAI SDK (v1.5.0)Model: gemini-2.5-flash-liteContainerization:
Docker📦 Docker SetupTo run the assistant in a containerized environment, use the provided Dockerfile:
Dockerfile# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime Stage
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "chatbot.dll"]
<img width="845" height="503" alt="image" src="https://github.com/user-attachments/assets/956672c2-9a0f-4efe-b00c-fc879c87397c" />

📸 Application PreviewUser InterfaceAI Response
🧪 Testing ResultsSample Prompt: "hi gemini i am kicsit student.
"Output: The assistant correctly identified the Hungarian origin of "Kicsit" and offered study assistance.
