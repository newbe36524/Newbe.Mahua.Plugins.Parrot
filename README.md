# Newbe.Mahua.Plugins.Parrot

先点击一下右上角的Star，开启隐藏功能。

> 如果暂时不知道这个仓库的目的，请先关注另外一个项目 ： <https://github.com/newbe36524/Newbe.Mahua.Framework>

[![GitHub last commit](https://img.shields.io/github/last-commit/Newbe36524/Newbe.Mahua.Plugins.Parrot.svg?style=flat-square)]()
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors)

## 你打麻花，谁疼？麻花疼。

QQ协议实现也有不少，QQ机器人平台有不少，这些平台大多具有不同的接口，对接开发存在巨大困难。

使用该SDK开发可以实现一次开发，运行于多个不同平台的绝佳体验。

SDK提供多种可用的跨进程通信方案，开发者可以从中灵活选择自己适用的开发语言进行对接。

你只要基于SDK的接口开发一次，便可以将你的插件发布到所有支持的QQ机器人平台。

不用担心某个平台被咔嚓。

## 主要内容

本仓库中包含了各种编程语言和对接方式对“嘤鹉学舌”这个插件的实现。这些示例基于 [Newbe.Mahua 2.X](https://github.com/newbe36524/Newbe.Mahua.Framework) 提供的相关接口。以下便是本仓库中的示例情况。

| 编程语言   | 调用方式  | 回调方式  | 作者       | 链接                                                                                                        | 备注                          |
| ---------- | --------- | --------- | ---------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------- |
| C#         | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/CSharp/Http/WebFormNET35)           | WebForm Framework 3.5         |
| C#         | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/CSharp/Http/WinFormNET461)          | WinForm Framework 4.6.1       |
| C#         | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/CSharp/Http/ConsoleNET461)          | Console Framework 4.6.1       |
| C#         | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/CSharp/Http/AspnetCoreNetCoreApp22) | Aspnetcore netcoreapp 2.2     |
| Typescript | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/Typescipt/Http/NodeExpress)         | node express                  |
| Javascript | HTTP      | HTTP      | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/Javascript/Http/NodeExpress)        | node express                  |
| Java       | HTTP      | HTTP      | 待补充     |                                                                                                             |                               |
| C++        | HTTP      | HTTP      | 待补充     |                                                                                                             |                               |
| Python     | HTTP      | HTTP      | 待补充     |                                                                                                             |                               |
| PHP        | HTTP      | HTTP      | 待补充     |                                                                                                             |                               |
| Javascript | Websocket | Websocket | newbe36524 | [点击跳转](https://github.com/newbe36524/Newbe.Mahua.Plugins.Parrot/src/Javascript/Websocket/Broswer)       | browser 客户端连接Newbe.Mahua |

调用：是指开发者的进程调用 Newbe.Mahua 的接口。

回调：是指 Newbe.Mahua 调用 开发者的进程的接口。

每个项目下都有`README.md`，里面记录了关于项目如何使用的相关内容，希望读者参阅。

## Contributors

Thanks goes to these wonderful people ([emoji key](https://github.com/kentcdodds/all-contributors#emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
| [<img src="https://avatars1.githubusercontent.com/u/7685462?v=4" width="100px;" alt="Newbe36524"/><br /><sub><b>Newbe36524</b></sub>](http://www.newbe.pro)<br />[📖](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524 "Documentation") [💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524 "Code") |
| :---: |
<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/kentcdodds/all-contributors) specification. Contributions of any kind welcome!

## 说在最后面

开发本SDK的目的是为了促进.Net技术的交流学习。

由本SDK衍生的任何产品均与本SDK无关！

由本SDK支持的QQ自动化管理助手平台均与本SDK无关！

禁止用于国家或地区法律法规所禁止的范围！

**最后，但是最重要的，一定要Star一下！**

[借一步说话](http://www.newbe.pro/donate.html)