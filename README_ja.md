# Sitecoredemo Docker ヘッドレススターターキット

## 必要システム

- NodeJs 21.x
- .NET 6.0 SDK
- Visual Studio Code
- Docker for Windows, with Windows Containers enabled

より詳しい情報を確認する場合は、Sitecore Docker Container に関して確認をしてください。

## セットアップ

ブログシリーズで紹介をした手順をすべて含めているプロジェクトになります。

1. .env.example のファイルをコピーして .env ファイルを作成します。
2. 以下のコマンドを管理者権限のあるターミナルで実行します。ライセンスファイルのある場所は任意です。

   ```ps1
   .\init.ps1 -InitEnv -LicenseXmlPath "C:\projects\license\license.xml" -AdminPassword "DesiredAdminPassword"
   ```

3. `up.ps1` を実行してください。

   ```ps1
   .\up.ps1
   ```

しばらくすると Next.js と Sitecore が動いている環境が起動します。

このプロジェクトの作成手順は[ブログ](https://haramizu.com/ja-JP)を参照してください。
