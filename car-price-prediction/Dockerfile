# Use the official Python image as the base
FROM python:3.10-slim

# Set working directory inside the container
WORKDIR /app

# Copy the requirements file and install dependencies
COPY requirements.txt .
RUN pip install --upgrade pip && pip install --no-cache-dir -r requirements.txt

# Copy all files and directories to the container's working directory
COPY . .

# Expose the default FastAPI port
EXPOSE 8000

# Command to run the FastAPI app
CMD ["uvicorn", "api:app", "--host", "0.0.0.0", "--port", "8000"]
