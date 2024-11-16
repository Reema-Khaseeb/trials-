# Car Price Prediction

## Table of Contents
1. [Problem Statement](#problem-statement)
2. [Business Goal](#business-goal)
3. [Features](#features)
4. [Technologies Used](#technologies-used)
5. [Getting Started](#getting-started)
6. [API Endpoints](#api-endpoints)
7. [Docker Hub Repository](#docker-hub-repository)

## Problem Statement
To understand the factors on which the pricing of cars depends. Specifically, they want to understand the factors affecting the pricing of cars in the Palestinian market. The company wants to know the following:

* Which variables are significant in predicting the price of a car 
* How well do these variables describe the price of a car Based on various market surveys

I'll utilize a large data set scrapped with different types of cars across the Palestinian market.


## Bussiness Goal
The management aims to model car prices using the provided independent variables. This model will help:
- Understand price variations with respect to the variables.
- Enable modifying car designs and strategies to align with price levels.
- Gain insights into the pricing dynamics of a new market.

---

## Features
1. Data cleaning.
2. Exploratory Data Analysis (EDA).
3. Feature engineering.
4. Feature selection.
5. Data modeling and evaluation.
6. Deployment: API endpoints:
   - Health check.
   - Car price prediction.
7. Containerized for seamless deployment using Docker.

---

## Technologies Used
- Python
- FastAPI
- Docker

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/Reema-Khaseeb/trials-.git
cd car-price-prediction
```

The application will be accessible at http://localhost:8000.

#### API Endpoints
1. **Health Check Endpoint**  
   - **Method**: `GET`  
   - **Endpoint**: `/`  
   - **Description**: Check if the API is running.

2. **Predict Car Price Endpoint**  
   - **Method**: `POST`  
   - **Endpoint**: `/predict/`
   - **Description**: Provide car data as input to get a predicted price.  
     **Example Payload**:

        ```json
        {
            "car_color": "أبيض",
            "fuel_type": "بنزين",
            "car_type": "خصوصي",
            "car_license": "فلسطينية",
            "gear_type": "اوتوماتيك",
            "windows": "الكتروني",
            "motor_power": 2000,
            "speedometer": 50000,
            "passengers_number": 5,
            "payment_method": "نقدا فقط",
            "car_state": "للبيع فقط",
            "ex_owners": 1,
            "additions": "مُكيّف, إغلاق مركزي, جهاز إنذار, مسجل CD, فتحة سقف, جنطات مغنيسيوم, فرش جلد, وسادة حماية هوائية"
        }
        ```

        **Response**:
        ```json
        {
            "prediction": 70038.61989474502
        }
        ```


## Docker Hub Repository
The Docker image is available on Docker Hub:
[Car Price Prediction Image](https://hub.docker.com/repository/docker/reema21/car-price-prediction)

* Pull the image:
    ```
    docker pull reema21/car-price-prediction:latest
    ```

* Run the Image
    ```bash
    docker run -d -p 8000:8000 reema21/car-price-prediction:latest
    ```

After running the container, the application will be accessible at:
http://localhost:8000
