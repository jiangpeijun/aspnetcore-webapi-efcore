# efcore
💡**声明**


![cover](./docs/mj2a1.jpg)
## 步骤 
- [x] git clone
- [x] 下载 SSMS
- - [ ] https://learn.microsoft.com/zh-cn/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16&source=recommendations#download-ssms
- [x] 配置 SSMS
- [ ] 连接对象资源管理器
- - [ ] 服务器类型：数据库引擎
- - [ ] 服务器名称：DESKTOP-IO34AG5
- - [ ] 身份验证：Window 身份验证
- - [ ] 加密：强制
- - [ ] 勾选 信任服务器证书
- [x] SSMS 中新建数据库 Employees，新建 employee，并设置 Id，Name，LastName，Title
- [x] 项目 中Connected Services的 Secrets.json
      {"ConnectionStrings:SqlServer": "Data Source=DESKTOP-IO34AG5;Initial Catalog=Employees;Integrated Security=True;Trust Server Certificate=True"}
- [x] 项目 中Connected Services的 SQL Server 数据库连接 选择 SQL Server 数据库（本地 SQL Server 数据库）
- [x] 项目 中Connected Services的 SQL Server 数据库连接 配置参数
- [ ] 连接字符串名称 ConnectionStrings:SqlServer
- [ ] 连接字符串值 Data Source=DESKTOP-IO34AG5;Initial Catalog=Employees;Integrated Security=True;Trust Server Certificate=True
- [x] postman访问 https://localhost:7236/api/Employee
  



## Vercel 一键部署

[![Deploy with Vercel](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https://github.com/Dooy/chatgpt-web-midjourney-proxy&env=OPENAI_API_BASE_URL&env=OPENAI_API_KEY&env=MJ_SERVER&env=MJ_API_SECRET&project-name=chatgpt-web-midjourney-proxy&repository-name=chatgpt-web-midjourney-proxy)

## env 环境变量

| 环境变量 | 说明 | 默认值 |docker等部署| vercel 部署|
| --- | --- | --- | --- | --- |
| OPENAI_API_BASE_URL | OpenAI API 接口地址 | https://api.openai.com | ✅ |  ✅|
| OPENAI_API_KEY | OpenAI API 密钥 |  sk-xxxxx | ✅ |  ✅|
| OPENAI_API_MODEL |  默认模型 | gpt-3.5-turbo  | ✅ |  ✅|
| MJ_SERVER |  mj proxy 接口地址  |[搭建参考](https://github.com/novicezk/midjourney-proxy) | ✅ |  ✅|
| MJ_API_SECRET |  mj proxy | 空  | ✅ |  ✅|
| SUNO_SERVER |  SUNO API 接口地址  | [搭建参考](https://github.com/SunoAI-API/Suno-API) | ✅ |  ✅|
| SUNO_KEY |  SUNO API 的key | 空  | ✅ |  ✅|
| AUTH_SECRET_KEY |  访问授权密码 | 无  | ✅ |   x|
| API_UPLOADER |  支持上传 | 关闭  | ✅ |  x|
| HIDE_SERVER |  前端ui隐藏服务端|    | ✅ |  x|
| CUSTOM_MODELS |  自定义可选模型 | 无  | ✅ |  ✅|
| TJ_BAIDU_ID |  百度统计ID | 无  | ✅ |  ✅|
| TJ_GOOGLE_ID |  谷歌统计ID | 无  | ✅ |  ✅|
| SYS_NOTIFY |  系统通知，支持HTML | 无  | ✅ |  ✅|
| DISABLE_GPT4 |  禁用GPT-4 | 无  | ✅ |  ✅|
| GPT_URL | 自定 GPT_URL=/gpts.json  | 无 也可自己的外链 | ✅ |  ✅|
| UPLOAD_IMG_SIZE | gpt4v 上传图片大小 |  1 | ✅ |  ✅|
| SYS_THEME | 默认主题 `light`或者`dark`  | dark | ✅ |  ✅|
| MJ_IMG_WSRV | 是否开启 `wsrv`图床  | 无(关闭)  | ✅ |  ✅|
| AUTH_SECRET_ERROR_COUNT | 防爆破验证：验证次数触发 NGINX 请设置 `proxy_set_header   X-Forwarded-For  $remote_addr`  | 无  | ✅ |  x|
| AUTH_SECRET_ERROR_TIME | 防爆破验证：停留时间 单位分钟  | 无  | ✅ |  x|
| CLOSE_MD_PREVIEW | 是否不关闭输入预览 | 无  | ✅ |  ✅|
| UPLOAD_TYPE | 指定上传方式 [`R2` R2上传] [`API` 跟随UI前端中转]、[`Container` 本地容器]、[`MyUrl` 自定义链接]  |  空 | ✅ |  x|
| MENU_DISABLE  | 菜单禁用 可选:gpts,draws,gallery,music |  空 | ✅ |  ✅|
| VISION_MODEL  | 默认使用的识图 可选:`gpt-4o`,`gpt-4-turb`,`gpt-4-vision-preview`等 |  空 | ✅ |  ✅|
| SYSTEM_MESSAGE  | 自定义默认角色消息 |  空 | ✅ |  ✅|
| CUSTOM_VISION_MODELS  | 自定义可视图模型 用`,` 分开 |  空 | ✅ |  ✅|

  

