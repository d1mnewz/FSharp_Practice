#r "../packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open FSharp.Data;
open System
open System.Net.Mail

let server = "smtp.gmail.com" // ConfigurationManager.AppSettings.["mailserver"]
let sender = "icanmakeyoucryo.o@gmail.com" // ConfigurationManager.AppSettings.["mailsender"]
let password = "arizonaboys" // ConfigurationManager.AppSettings.["mailpassword"] |> my-decrypt
let port = 587
let SendTest email topic msg = // doeesnt work
    use msg = 
        new MailMessage(
            sender, email, topic, 
            msg)
            
    msg.Bcc.Add "d1mnewz@gmail.com"
    use client = new SmtpClient(server, port)
    client.EnableSsl <- true
    client.DeliveryMethod <- SmtpDeliveryMethod.Network
    client.UseDefaultCredentials <- false
    client.Credentials <- System.Net.NetworkCredential(sender, password)
    client.Send msg


let metaTitle (doc:HtmlDocument) =
    doc.Descendants "meta"
    |> Seq.choose (fun x ->
        match x.AttributeValue("name"), x.AttributeValue("property") with
        | "title", _
        | "headline", _
        | "twitter:title", _
        | _, "og:title" ->
            Some(x.AttributeValue("content"))
        | _, _ -> None
    )

let titles (doc:HtmlDocument) =
    let tagged (tag:string) =
        doc.Descendants tag |> Seq.map (fun x -> x.InnerText())
    Seq.concat [tagged "title"; metaTitle doc; tagged "h1"]

let title (doc:HtmlDocument) =
    titles doc |> Seq.tryHead


let finalTitle = "http://lviv.azurebootcamp.net/"
                 |> HtmlDocument.Load
                 |> titles
                 |> Seq.head

if(finalTitle <> "Azure Bootcamp 2017 Львів – 22 квітня, вул. Замарстинівська 83А")
then SendTest "d1mnewz@gmail.com" "Status: Failed" finalTitle

