﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Markup;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("Atlib.Presentation")]
[assembly: AssemblyDescription("Atlibプレゼンテーションライブラリ")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("atachimiko")]
[assembly: AssemblyProduct("Atlib.Presentation")]
[assembly: AssemblyCopyright("Copyright © atachimiko 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、その型はこのアセンブリ内で COM コンポーネントから 
// 参照不可能になります。COM からこのアセンブリ内の型にアクセスする場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// 次の GUID は、このプロジェクトが COM に公開される場合の、typelib の ID です
[assembly: Guid("2473067f-01ef-404a-a4b9-110f1898ace7")]

// アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.8.0")]
[assembly: AssemblyFileVersion("1.0.8.0")]

[assembly: XmlnsDefinition("http://schemas.atachimiko.net/atlib", "Atlib.Presentation")]
[assembly: XmlnsDefinition("http://schemas.atachimiko.net/atlib", "Atlib.Presentation.Behaviors")]
[assembly: XmlnsDefinition("http://schemas.atachimiko.net/atlib", "Atlib.Presentation.Converters")]
[assembly: XmlnsPrefix("http://schemas.atachimiko.net/atlib", "atlib")]