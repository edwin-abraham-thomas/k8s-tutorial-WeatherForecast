docker build -f WeatherForecast/Dockerfile . -t edwinatdev/weatherforecast:latest

docker push edwinatdev/weatherforecast:latest

docker build -f WeatherForecastProxy/Dockerfile . -t edwinatdev/weatherforecastproxy:latest

docker push edwinatdev/weatherforecastproxy:latest

pause