# Functional Koans - F# #

EdgeCaseによる素晴らしい [Ruby koans](http://github.com/edgecase/ruby_koans) に影響を受けて作られた、
F# koansの目的は、テストを通じてF#を教えることです。

最初に koans を実行すると、実行時のエラーと、エラーが発生した場所
を示すスタックトレースが表示されます。あなたのゴールはエラーを
なくすことです。それぞれのエラーを修正していくうちに、F# 言語や
関数型プログラミング全般について何かを学ぶことができるはずです。

F# の悟りへの旅は AboutAsserts.fs ファイルから始まります。これらのkoanは非常に
シンプルなものですので、考えすぎないようにしてください。より多くのkoanを読んで
いくうちに、F#の構文がどんどん紹介されていき、より複雑な問題を解決したり、より
高度なテクニックを使うことができるようになります。

### Running with Docker

dockerを使ってウォッチモードで起動するには、以下のコマンドを実行します。

`$ ./docker.sh`

### Prerequisites

F# Koansをビルドして実行するには[.Net Core 3.1](https://www.microsoft.com/net/download/core)が必要です。プロジェクトをビルドする前にインストールされていることを確認してください。これは、最新のF#や.NETアプリケーションの多くが使用している.NET Coreの長期保守リリースです。

さらに、プロジェクトを実行するための[Visual Studio Code](https://code.visualstudio.com/)設定を提供します。
Visual Studio CodeでF#プロジェクトを実行できるようにするには、
[Ionideプラグイン](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp)もインストールする必要があります。

### Running the Koans from the command line (.Net Core)

1. Koansをビルドするには、プロジェクトルートで `dotnet build` コマンドを実行します。

2. Koansを実行するには、ルートディレクトリで `dotnet run -p FSharpKoans/FSharpKoans.fsproj` を実行するか、 `FSharpKoans` プロジェクトディレクトリで `dotnet run` を実行してください。

### Running the Koans in Visual Studio Code

1. Ionide-fharpプラグインをインストールした状態でVisual Studio Codeのプロジェクトディレクトリを開き、
F5を押してKoansをビルドして起動します（起動前にプロジェクトをビルドするのに時間がかかります）。

### Using dotnet-watch

また、[dotnet-watch](https://github.com/aspnet/Docs/blob/master/aspnetcore/tutorials/dotnet-watch.md)を使って変更内容を自動的にリロードすることもできます。
これを行うには、 `FSharpKoans` ディレクトリに移動し、 `dotnet watch run` を実行してください。これで、プロジェクトコードを変更した後、自動的にリロードされ、テストが再実行されます。
