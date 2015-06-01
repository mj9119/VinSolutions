<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="VinSolutions._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Project Name: VinSolutions
    </h2>
    <p>
        Project Description: PP 1.4: In the programming language of your choice, write a program that parses a sentence and replaces each word with the following: first letter, number of distinct characters between first and last character, and last letter.  For example, Smooth would become S3h.  Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.
    </p>
    <p>
        IDE: MS Visual Web Developer 2010 Express <br />
        Assumptions below: <br />
        Commas are allowed in sentences. <br />
        One and two letter words are considered to have zero distinct characters between first and last letter. <br />
        The one letter in a one letter word is considered to be its first and its last letter. <br />
        Max input sentence Length = 100 chars <br />
        Output field length = 150 chars.  Accomodates situations where output length > input due to one letter words. <br />        
        Words containing contractions, like the word "can't", would require additional programming. <br /> 
        All sentences must contain a period at the end. <br />
        
        Example: input sentence contains many single char words <br />
        Examples below ---> For each example, the arrow points to program output. <br />
        It is not smooth.  --> I0t i0s n1t s3h.  <br />
        Here is a longer sentence containing words of various lengths including one letter words. --> "H2e i0s a0a l4r s4e c5g w3s o0f v5s l5s i6g o1e l2r w3s." <br />
 
    </p>
    <p>                
        <asp:TextBox ID="txtEnterSentence" runat="server" Width="477px" MaxLength="100" Text="It is not smooth."></asp:TextBox>        
        </p>
    <p>                
        <asp:Button ID="ProcessSentence" runat="server" Text="Click to Process Sentence" 
            onclick="ProcessSentence_Click" />
        </p>
    <p>                
        <asp:Label ID="lblSentenceResults" runat="server" Text="Results overwrite this text when the button is clicked. "></asp:Label>
        <br />
        </p>
</asp:Content>
