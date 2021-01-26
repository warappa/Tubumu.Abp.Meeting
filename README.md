# Tubumu.Abp.Meeting

基于 [Mediasoup](https://github.com/versatica/mediasoup) 的 [Abp](https://www.abp.io/) vNext 视频会议模块。

## 一、安装

### 1、创建项目

``` shell
# 当前目录：任意
mkdir Sample && cd Sample
abp new Sample
```

### 2、安装 Tubumu.Abp.Meeting 模块

使用 Abp CLI 安装:

``` shell
# 当前目录：Sample
cd src/Sample.Web
# 当前目录：Sample/src/Sample.Web
abp add-package Tubumu.Abp.Meeting
```

或者手工安装，在 Nuget 搜索 [Tubumu.Abp.Meeting](https://www.nuget.org/packages/Tubumu.Abp.Meeting/) 并安装，然后修改 `SampleWebAbpModule`:

``` C#
// ...
    typeof(AbpSwashbuckleModule),
    // 配置点：1
    typeof(TubumuAbpMeetingModule)
    )]
public class SampleWebModule : AbpModule
// ...
```

### 3、下载配置文件及修改 IP

将 [mediasoupsettings.json](https://raw.githubusercontent.com/albyho/Tubumu.Abp.Meeting/main/samples/Tubumu.Abp.Meeting.Sample/src/Tubumu.Abp.Meeting.Sample.Web/mediasoupsettings.json) 配置文件下载到 `Sample.Web` 项目中。

``` shell
# 当前目录：Sample/src/Sample.Web
curl -o mediasoupsettings.json https://raw.githubusercontent.com/albyho/Tubumu.Abp.Meeting/main/samples/Tubumu.Abp.Meeting.Sample/src/Tubumu.Abp.Meeting.Sample.Web/mediasoupsettings.json
```

打开 `mediasoupsettings.json` 配置文件，搜索 `AnnouncedIp` 键将值修改为本机在局域网中的 IP。

``` json
// ...
    "WebRtcTransportSettings": {
      "ListenIps": [
        {
          "Ip": "0.0.0.0",
          "AnnouncedIp": "192.168.1.5" // 修改为本机在在局域网中的 IP 。
        }
      ],
      "InitialAvailableOutgoingBitrate": 1000000,
      "MinimumAvailableOutgoingBitrate": 600000,
      "MaxSctpMessageSize": 262144,
      // Additional options that are not part of WebRtcTransportOptions.
      "MaximumIncomingBitrate": 1500000
    },
    // 用于 FFmpeg 推流
    "PlainTransportSettings": {
      "ListenIp": {
        "Ip": "0.0.0.0",
        "AnnouncedIp": "192.168.1.5" // 修改为本机在在局域网中的 IP 。
      },
      "MaxSctpMessageSize": 262144
    }
// ...
```

### 4、Web 前端

可将 Sample 的前端项目的源码是 [tubumu-abp-meeting-sample-client](https://github.com/albyho/Tubumu.Abp.Meeting/tree/main/samples/Tubumu.Abp.Meeting.Sample/src/tubumu-abp-meeting-sample-client) 编译并复制到 Sample.Web 项目的 wwwroot 目录下。

### 5、新增菜单

菜单连接至 Web 前端的首页。

## 二、录屏

![](https://github.com/albyho/Tubumu.Abp.Meeting/raw/main/art/ScreenCAP01.gif)

## 三、截图

[Screenshots](https://github.com/albyho/Tubumu.Abp.Meeting/blob/main/Screenshots.md)
