# car-price-prediction

## Problem Statement
To understand the factors on which the pricing of cars depends. Specifically, they want to understand the factors affecting the pricing of cars in the Palestinian market. The company wants to know the following:

* Which variables are significant in predicting the price of a car 
* How well do these variables describe the price of a car Based on various market surveys

I'll utilize a large data set scrapped with different types of cars across the Palestinian market.


## Bussiness Goal
We are required to model the price of cars with the available independent variables. It will be used by the management to understand how exactly the prices vary with the independent variables. They can accordingly manipulate the design of the cars, the business strategy etc. to meet certain price levels. Further, the model will be a good way for management to understand the pricing dynamics of a new market.


## Features
1. Data cleaning
2. Exploratory Data Analysis
3. Feature Engineering
4. Feature selection
5. Data Modelling and evaluation
6. Deployment: Easy-to-use API endpoints for health checks and price prediction.
7. Containerized for seamless deployment using Docker.

## Getting Started

### Technologies Used
- Python
- FastAPI
- Docker

### Clone the Repository

```bash
git clone https://github.com/Reema-Khaseeb/trials-.git
cd car-price-prediction
```

The application will be accessible at http://localhost:8000.

#### API Endpoints
1. Health Check
Endpoint: `GET /`
Description: Check if the API is running.

2. Predict Car Price
Endpoint: `POST /predict/`
Description: Provide car data as input to get a predicted price.
Example payload:
```
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

Response:
```
{
    "prediction": 70038.61989474502
}
```


## Docker Hub Repository
The Docker image is available on Docker Hub:
[Car Price Prediction Image](https://hub.docker.com/repository/docker/reema21/car-price-prediction)

To pull the image:
```
docker pull reema21/car-price-prediction:latest
```