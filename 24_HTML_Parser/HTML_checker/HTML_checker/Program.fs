// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open FSharp.Data;
open System
open System.Net.Mail


let server = "smtp.gmail.com" // ConfigurationManager.AppSettings.["mailserver"]
let sender = "fsharpie.send@gmail.com" // ConfigurationManager.AppSettings.["mailsender"]
let password = "fsharpAWESOME" // ConfigurationManager.AppSettings.["mailpassword"] |> my-decrypt
let port = 587
let SendTest email topic msg = 
    use msg = 
        new MailMessage(
            sender, email, topic, 
            msg)
    let client = new SmtpClient(server, port)
    client.EnableSsl <- true
    client.Timeout <- 20000
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


let finalTitle (link:string) = try
                                link
                                |> HtmlDocument.Load
                                |> titles
                                |> Seq.head
                                with 
                                | :? Exception as ex -> ex.Message

[<EntryPoint>]
let main argv = 
    let website = "http://lviv.azurebootcamp.net/"
    if(finalTitle website <> "Azure Bootcamp 2017 Львів – 22 квітня, вул. Замарстинівська 83А")
    then
            SendTest "d1mnewz@gmail.com" "Status: Failed" (website + " is down :( ")
 
    0 // return an integer exit code

 





