open Polyjuice.Windows
open System.Xml

let path = "D:/git/Polyjuice/src/policies/windows/admx/ja-JP/msedge.adml"
let doc = XmlDocument(PreserveWhitespace = true)
doc.Load path
let root = doc.DocumentElement
let a = 0