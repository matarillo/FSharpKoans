namespace FSharpKoans
open FSharpKoans.Core
open System.Collections.Generic

//---------------------------------------------------------------
// .NETのコレクションについて
//
// F#は他のCLR言語とシームレスに相互運用できるように構築されて
// いるため、C#やVBのプログラマーにはすでにお馴染みの、基本的な
// .NETのコレクション型をすべて使用することができます。
//---------------------------------------------------------------
[<Koan(Sort = 14)>]
module ``DotNETのコレクションについて`` =

    [<Koan>]
    let ``.NETのリストを作る``() =
        let fruits = new List<string>()

        fruits.Add("apple")
        fruits.Add("pear")
 
        AssertEquality fruits.[0] __
        AssertEquality fruits.[1] __

    [<Koan>]
    let ``.NETのディクショナリーを作る``() =
        let addressBook = new Dictionary<string, string>()

        addressBook.["Chris"] <- "Ann Arbor"
        addressBook.["SkillsMatter"] <- "London"

        AssertEquality addressBook.["Chris"] __
        AssertEquality addressBook.["SkillsMatter"] __

    [<Koan>]
    let ``.NETの型に対してコンビネーターを使う``() =
        let addressBook = new Dictionary<string, string>()

        addressBook.["Chris"] <- "Ann Arbor"
        addressBook.["SkillsMatter"] <- "London"

        let verboseBook = 
            addressBook
            |> Seq.map (fun kvp -> sprintf "Name: %s - City: %s" kvp.Key kvp.Value)
            |> Seq.toArray

        // 注: F#のseq型は .NETのIEnumerableインターフェースのエイリアスです。
        //     ListやArrayモジュールのように、Seqモジュールには、seq/IEnumerableを
        //     実装した型に対する操作を実行するために組み合わせることができる関数が
        //     含まれています。

        AssertEquality verboseBook.[0] __
        AssertEquality verboseBook.[1] __

    [<Koan>]
    let ``要素をスキップする``() =
        let original = [0..5]
        let result = Seq.skip 2 original
        
        AssertEquality result __

    [<Koan>]
    let ``最大値を見つける``() =
        let values = new List<int>()

        values.Add(11)
        values.Add(20)
        values.Add(4)
        values.Add(2)
        values.Add(3)

        let result = Seq.max values
        
        AssertEquality result __
    
    [<Koan>]
    let ``条件を指定して最大値を見つける``() =
        let getNameLength (name:string) =
            name.Length
        
        let names = [| "Harry"; "Lloyd"; "Nicholas"; "Mary"; "Joe"; |]
        let result = Seq.maxBy getNameLength names 
        
        AssertEquality result __
