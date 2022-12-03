# 🏓 Ping - Pong 🏓
> Status: Completed 👌

## About
It's a REST API planned by me for a college assignment, where I perform a simple API made with C# that uses URI resources to return `ping` (if you send pong) and `pong` (if you send ping).
> TThe result from request are in JSON format and when is send wrong path the return HTTP 404 (NOT FOUND).

![image](https://user-images.githubusercontent.com/99461398/205456350-528f2d21-2b9c-4739-92d3-787ed08387ea.png)

## Routes
The root path is `PingOrPong`. So, when you run the project in localhost you must use `https://localhost:{port}/PingOrPong/{you-request}` or you can use swagger using `https://localhost:{port}/swagger` and do request using it.

![Captura de tela de 2022-11-17 01-45-02](https://user-images.githubusercontent.com/99461398/202358290-8460cebc-971b-4fbc-998c-3a3d60133cc9.png)

## GET

### Path
> PingOrPong/Pong
#### Result

``` json 
{
    "msg": "Ping"
}
```

### Path
> PingOrPong/Ping
#### Result

``` json 
{
    "msg": "Pong"
}
```

## Getting started
### Prerequisites
You must have .NET 6 installed.

So you just use git clone and into root folder run:
```
$ dotnet run
```
