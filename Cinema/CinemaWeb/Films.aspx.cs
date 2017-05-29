using Cinema;
using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Films : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        FilmCollection a = Utility.MakeRequest<FilmCollection>(ConfigurationManager.AppSettings["apiurl"]);
        webFilmCollectionViewer.DataSource = a.Results;
        webFilmCollectionViewer.ItemDataBound += webFilmCollectionViewer_ItemDataBound;
        webFilmCollectionViewer.DataBind();


    }

    private void webFilmCollectionViewer_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        Film film= e.Item.DataItem as Film;
        Label titleLabel=(Label)e.Item.FindControl("Title");
        titleLabel.Text = film.Title;
        HyperLink linkToFilm = (HyperLink)e.Item.FindControl("linkToFilm");
        linkToFilm.NavigateUrl = film.WikipediaUrl;
    }
}