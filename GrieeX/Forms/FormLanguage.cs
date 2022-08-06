using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrieeX.GrieeXBase;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace GrieeX.Forms
{
    public partial class frmMain
    {


        public void EmitLanguage()
        {
            //try
            //{
            //this.ribbon.ApplicationButtonText = Language.FindKey("Menu", "0").Value;
            this.Text = Language.FindKey("Forms", "0").Value;
            this.dockPanel2.Text = Language.FindKey("Strings", "94").Value;

            this.rpgAdd.Text = Language.FindKey("Buttons", "0").Value;
            this.ribbonPage1.Text = Language.FindKey("Strings", "51").Value;
            this.ribbonPage2.Text = Language.FindKey("Strings", "92").Value;
            this.ribbonPage3.Text = Language.FindKey("Strings", "93").Value;
            this.rpgFastFilter.Text = Language.FindKey("Strings", "101").Value;
            this.cbFilterType.Caption = Language.FindKey("Strings", "102").Value;

            this.btnAddWithFile.Caption = Language.FindKey("Buttons", "1").Value;
            this.btnAddManual.Caption = Language.FindKey("Buttons", "2").Value;
            this.btnMultiFile.Caption = Language.FindKey("Buttons", "33").Value;
            this.btnDelete.Caption = Language.FindKey("Buttons", "3").Value;
            this.btnSearch.Caption = Language.FindKey("Buttons", "4").Value;
            this.btnStatistics.Caption = Language.FindKey("Buttons", "5").Value;
            this.btnAbout.Caption = Language.FindKey("Buttons", "17").Value;
            this.btnExit.Caption = Language.FindKey("Buttons", "18").Value;
            this.btnPlay.Caption = Language.FindKey("Buttons", "34").Value;
            this.btnEdit.Caption = Language.FindKey("Buttons", "35").Value;
           // this.btnHistory.Caption = Language.FindKey("Buttons", "36").Value;
            this.btnTop10.Caption = Language.FindKey("Buttons", "37").Value;
            this.btnRandom.Caption = Language.FindKey("Buttons", "43").Value;
            this.btnListOptions.Caption = Language.FindKey("Buttons", "38").Value;
            this.btnVersionControl.Caption = Language.FindKey("Buttons", "47").Value;
            this.btnDropboxUpload.Caption = Language.FindKey("Buttons", "59").Value;
            this.btnDropboxDownload.Caption = Language.FindKey("Buttons", "60").Value;
            this.btnDatabaseRepair.Caption = Language.FindKey("Buttons", "60").Value;

            this.mnuAdd.Caption = Language.FindKey("Menu", "1").Value;
            this.mnuImport.Caption = Language.FindKey("Menu", "2").Value;
            this.mnuExport.Caption = Language.FindKey("Menu", "3").Value;
            this.mnuTotalUpdates.Caption = Language.FindKey("Menu", "4").Value;
            this.mnuStatistics.Caption = Language.FindKey("Menu", "5").Value;
            this.mnuSettings.Caption = Language.FindKey("Menu", "6").Value;
            this.mnuExportToExcel.Caption = Language.FindKey("Menu", "7").Value;
            this.mnuAddWithFile.Caption = Language.FindKey("Buttons", "1").Value;
            this.mnuAddManual.Caption = Language.FindKey("Buttons", "2").Value;
            this.mnuMultiFile.Caption = Language.FindKey("Buttons", "33").Value;
            this.mnuBackup.Caption = Language.FindKey("Menu", "28").Value;
            this.mnuExit.Caption = Language.FindKey("Menu", "20").Value;
            this.mnuBackupFromFile.Caption = Language.FindKey("Menu", "29").Value;
            this.mnuRestoreFromFile.Caption = Language.FindKey("Menu", "30").Value;
            this.mnuOtherFunctions.Caption = Language.FindKey("Menu", "31").Value;
            this.mnuCopyPictures.Caption = Language.FindKey("Menu", "32").Value;
            this.mnuCopyPictures.Description = Language.FindKey("Strings", "118").Value;


            this.mnuAddManualG.Text = Language.FindKey("Menu", "22").Value;
            this.mnuEdit.Text = Language.FindKey("Menu", "23").Value;
            this.mnuDelete.Text = Language.FindKey("Menu", "24").Value;
            this.mnuFolder.Text = Language.FindKey("Menu", "25").Value;
            this.mnuSeen.Text = Language.FindKey("Menu", "26").Value;
            this.mnuNotSeen.Text = Language.FindKey("Menu", "27").Value;



            this.gvList.GroupPanelText = Language.FindKey("Strings", "99").Value;

            this.cl_Seen.Caption = Language.FindKey("Strings", "13").Value;
            this.cl_InsertDate.Caption = Language.FindKey("Strings", "37").Value;
            this.cl_PersonalRating.Caption = Language.FindKey("Strings", "45").Value;
            this.cl_ArchivesNumber.Caption = Language.FindKey("Strings", "36").Value;
            this.cl_Country.Caption = Language.FindKey("Strings", "11").Value;
            this.cl_Director.Caption = Language.FindKey("Strings", "3").Value;
            this.cl_Dubbing.Caption = Language.FindKey("Strings", "44").Value;
            this.cl_Genre.Caption = Language.FindKey("Strings", "4").Value;
            this.cl_ImdbNumber.Caption = Language.FindKey("Strings", "35").Value;
            this.cl_Language.Caption = Language.FindKey("Strings", "10").Value;
            this.cl_OrginalName.Caption = Language.FindKey("Strings", "1").Value;
            this.cl_RunningTime.Caption = Language.FindKey("Strings", "8").Value;
            this.cl_SubTitle.Caption = Language.FindKey("Strings", "43").Value;
            this.cl_OtherName.Caption = Language.FindKey("Strings", "2").Value;
            this.cl_UserRating.Caption = Language.FindKey("Strings", "7").Value;
            this.cl_Votes.Caption = Language.FindKey("Strings", "9").Value;
            this.cl_Writer.Caption = Language.FindKey("Strings", "5").Value;
            this.cl_Year.Caption = Language.FindKey("Strings", "6").Value;
            this.cl_UserColumn1.Caption = Language.FindKey("Strings", "66").Value;
            this.cl_UserColumn2.Caption = Language.FindKey("Strings", "67").Value;
            this.cl_UserColumn3.Caption = Language.FindKey("Strings", "68").Value;
            this.cl_UserColumn4.Caption = Language.FindKey("Strings", "69").Value;
            this.cl_UserColumn5.Caption = Language.FindKey("Strings", "151").Value;
            this.cl_UserColumn6.Caption = Language.FindKey("Strings", "152").Value;
            this.cl_RlsType.Caption = Language.FindKey("Strings", "39").Value;
            this.cl_RlsGroup.Caption = Language.FindKey("Strings", "40").Value;
            this.cl_Budget.Caption = Language.FindKey("Strings", "147").Value;
            this.cl_ProductionCompany.Caption = Language.FindKey("Strings", "148").Value;
            this.cl_FileSize.Caption = Language.FindKey("Strings", "33").Value;
            this.cl_FileCount.Caption = Language.FindKey("Strings", "47").Value;


            ribbonPageGroup5.Text = Language.FindKey("Strings", "113").Value;
            beiLanguage.Caption = Language.FindKey("Strings", "114").Value;


            this.rgbiSkins.Gallery.Groups[0].Caption = Language.FindKey("Strings", "121").Value;
            this.rgbiSkins.Gallery.Groups[1].Caption = Language.FindKey("Strings", "122").Value;


            foreach (Key item in Language.FindSection("Languages").Keys)
            {
                CheckedListBoxItem itemSubTitle = new CheckedListBoxItem();
                itemSubTitle.CheckState = CheckState.Unchecked;
                itemSubTitle.Value = item.Name;
                itemSubTitle.Description = item.Value;
                repositoryItemCheckedComboBoxEdit.Items.Add(itemSubTitle);
            }

            foreach (Key item in Language.FindSection("ArchiveTypes").Keys)
            {
                ImageComboBoxItem itemArchivesType = new ImageComboBoxItem();
                itemArchivesType.Description = item.Value;
                itemArchivesType.Value = item.Name;
                repositoryItemImageComboBox.Items.Add(itemArchivesType);
            }


            //}
            //catch (Exception)
            //{
            //}
        }
    }

    public partial class frmMovie
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "2").Value;

            this.btnImdb.Caption = Language.FindKey("Buttons", "19").Value;
            this.btnBeyazperde.Caption = Language.FindKey("Buttons", "20").Value;
            this.btnDvdEmpire.Caption = Language.FindKey("Buttons", "21").Value;
            this.btnMovieGoods.Caption = Language.FindKey("Buttons", "22").Value;
            this.btnAmazon.Caption = Language.FindKey("Buttons", "23").Value;
            this.btnFilmComTr.Caption = Language.FindKey("Buttons", "24").Value;
            this.btnSinema.Caption = Language.FindKey("Buttons", "27").Value;
            this.btnSinematurk.Caption = Language.FindKey("Buttons", "28").Value;
            this.btnGoogle.Caption = Language.FindKey("Buttons", "32").Value;
            this.btnSinemalar.Caption = Language.FindKey("Buttons", "44").Value;
            this.btnAnimeGenTr.Caption = Language.FindKey("Buttons", "45").Value;
            this.btnAnimeNfo.Caption = Language.FindKey("Buttons", "46").Value;
            this.btnMovie.Caption = Language.FindKey("Buttons", "49").Value;
            this.btnPoster.Caption = Language.FindKey("Buttons", "50").Value;
            this.btnAnime.Caption = Language.FindKey("Buttons", "51").Value;
            this.btnSubtitle.Caption = Language.FindKey("Buttons", "52").Value;
            this.btnTurkceAltyaziOrg.Caption = Language.FindKey("Buttons", "57").Value;

            this.btnSave.Caption = Language.FindKey("Buttons", "6").Value;
            this.btnDelete.Caption = Language.FindKey("Buttons", "3").Value;
            this.btnPrevious.Caption = Language.FindKey("Buttons", "7").Value;
            this.btnNext.Caption = Language.FindKey("Buttons", "8").Value;
            this.btnInternet.Caption = Language.FindKey("Buttons", "9").Value;
            this.btnClose.Caption = Language.FindKey("Buttons", "16").Value;
        }
    }

    public partial class frmChangeCast
    {
        public void EmitLanguage()
        {
            lblS1.Text = Language.FindKey("Strings", "49").Value;
            lblS2.Text = Language.FindKey("Strings", "50").Value;
            btnOk.Text = Language.FindKey("Buttons", "10").Value;
            btnCancel.Text = Language.FindKey("Buttons", "11").Value;
            this.Text = Language.FindKey("Forms", "6").Value;
        }
    }

    public partial class frmImdb250
    {
        public void EmitLanguage()
        {
            this.cl_Rank.Caption = Language.FindKey("Strings", "82").Value;
            this.cl_Title.Caption = Language.FindKey("Strings", "83").Value;
            this.cl_Rating.Caption = Language.FindKey("Strings", "7").Value;
            this.cl_Votes.Caption = Language.FindKey("Strings", "9").Value;
            this.cl_ImdbNumber.Caption = Language.FindKey("Strings", "35").Value;
            this.Button1.Text = Language.FindKey("Buttons", "30").Value;
            this.Label1.Text = Language.FindKey("Strings", "84").Value;
            this.Label2.Text = Language.FindKey("Strings", "85").Value;
        }
    }

    public partial class frmStatistics
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "1").Value;
            this.tabGeneral.Text = Language.FindKey("Strings", "51").Value;
            this.tabDetails.Text = Language.FindKey("Strings", "56").Value;
            this.cl_Total.Caption = Language.FindKey("Strings", "57").Value;
            this.cl_Value.Caption = Language.FindKey("Strings", "58").Value;
            this.clSelect.Text = Language.FindKey("Strings", "59").Value;
            this.lvStatistics.Items[0].Text = Language.FindKey("Strings", "3").Value;
            this.lvStatistics.Items[1].Text = Language.FindKey("Strings", "6").Value;
            this.lvStatistics.Items[2].Text = Language.FindKey("Strings", "4").Value;
            this.lvStatistics.Items[3].Text = Language.FindKey("Strings", "19").Value;
            this.lvStatistics.Items[4].Text = Language.FindKey("Strings", "25").Value + " 1";
            this.lvStatistics.Items[5].Text = Language.FindKey("Strings", "25").Value + " 2";
            this.lvStatistics.Items[6].Text = Language.FindKey("Strings", "43").Value;
            this.lvStatistics.Items[7].Text = Language.FindKey("Strings", "44").Value;

            this.btnOk.Text = Language.FindKey("Buttons", "10").Value;
            this.cl_Str.Caption = Language.FindKey("Strings", "58").Value;
            this.cl_Count.Caption = Language.FindKey("Strings", "57").Value;
        }
    }

    public partial class frmSettings
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "3").Value;
            this.TreeView1.Nodes["ndGeneral"].Text = Language.FindKey("Strings", "51").Value;
            //this.TreeView1.Nodes["ndDescriptions"].Text = Language.FindKey("Strings", "60").Value;
            this.btnCancel.Text = Language.FindKey("Buttons", "11").Value;
            this.btnOk.Text = Language.FindKey("Buttons", "10").Value;
            this.grbLanguage.Text = Language.FindKey("Strings", "62").Value;
            this.lblLanguage.Text = Language.FindKey("Strings", "79").Value;
            this.grbPersonalColumns.Text = Language.FindKey("Strings", "65").Value;
            this.lblUserColumn1.Text = Language.FindKey("Strings", "66").Value;
            this.lblUserColumn2.Text = Language.FindKey("Strings", "67").Value;
            this.lblUserColumn3.Text = Language.FindKey("Strings", "68").Value;
            this.lblUserColumn4.Text = Language.FindKey("Strings", "69").Value;
            //this.TreeView1.Nodes["ndDescriptions"].Nodes["ndRlsGroup"].Text = Language.FindKey("Strings", "40").Value;
            //this.TreeView1.Nodes["ndDescriptions"].Nodes["ndRlsType"].Text = Language.FindKey("Strings", "39").Value;
            this.TreeView1.Nodes["ndPersonalColumns"].Text = Language.FindKey("Strings", "65").Value;
            this.TreeView1.Nodes["ndDefaultValues"].Text = Language.FindKey("Strings", "89").Value;
            this.grbGeneral.Text = Language.FindKey("Strings", "51").Value;
            this.chkImageLeft.Text = Language.FindKey("Strings", "71").Value;
            this.chkAutoClose.Text = Language.FindKey("Strings", "86").Value;
            this.chkAutoNewRecord.Text = Language.FindKey("Strings", "87").Value;
            this.grbRecord.Text = Language.FindKey("Strings", "88").Value;
            this.btnPlayerSelect.Text = Language.FindKey("Buttons", "31").Value;
            this.grbPlayer.Text = Language.FindKey("Strings", "90").Value;
            this.chkStartUpVersionControl.Text = Language.FindKey("Strings", "100").Value;
            this.lblSubtitle.Text = Language.FindKey("Strings", "43").Value;
            this.lblDubbing.Text = Language.FindKey("Strings", "44").Value;
            this.chkThe.Text = Language.FindKey("Strings", "138").Value;
            this.chkShowCastImage.Text = Language.FindKey("Strings", "153").Value;

            this.TreeView1.Nodes["ndConnection"].Text = Language.FindKey("Strings", "123").Value;
            this.chkProxy.Text = Language.FindKey("Strings", "124").Value;
            this.lblProxyServer.Text = Language.FindKey("Strings", "125").Value;
            this.lblProxyPort.Text = Language.FindKey("Strings", "126").Value;
            this.lblProxyUserName.Text = Language.FindKey("Strings", "127").Value;
            this.lblProxyPassword.Text = Language.FindKey("Strings", "128").Value;

        }
    }

    public partial class frmMultiFile
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "10").Value;
            chkRepeated.Text = Language.FindKey("Strings", "115").Value;
            btnFolderSelect.Text = Language.FindKey("Buttons", "31").Value;
            btnSelectAll.Text = Language.FindKey("Buttons", "14").Value;
            btnSelectNone.Text = Language.FindKey("Buttons", "15").Value;
            btnCancel.Text = Language.FindKey("Buttons", "11").Value;
            btnImport.Text = Language.FindKey("Buttons", "53").Value;
            Dosya.Text = Language.FindKey("Strings", "16").Value;
        }
    }

    public partial class frmMultiWebImport
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "4").Value;
            this.chkDirector.Text = Language.FindKey("Strings", "3").Value;
            this.chkGenre.Text = Language.FindKey("Strings", "4").Value;
            this.chkWriter.Text = Language.FindKey("Strings", "5").Value;
            this.chkYear.Text = Language.FindKey("Strings", "6").Value;
            this.chkUserRating.Text = Language.FindKey("Strings", "7").Value;
            this.chkRunningTime.Text = Language.FindKey("Strings", "8").Value;
            this.chkVotes.Text = Language.FindKey("Strings", "9").Value;
            this.chkLanguage.Text = Language.FindKey("Strings", "10").Value;
            this.chkCountry.Text = Language.FindKey("Strings", "11").Value;
            this.chkPlot.Text = Language.FindKey("Strings", "12").Value;
            this.chkCast.Text = Language.FindKey("Strings", "55").Value;
            this.lblDatabase.Text = Language.FindKey("Strings", "54").Value;
            this.btnStart.Text = Language.FindKey("Buttons", "12").Value;
            this.btnStop.Text = Language.FindKey("Buttons", "13").Value;
            this.ColumnHeader1.Text = Language.FindKey("Strings", "61").Value;
            this.ColumnHeader2.Text = Language.FindKey("Strings", "83").Value;
            this.btnSelectAll.Text = Language.FindKey("Buttons", "14").Value;
            this.btnSelectNone.Text = Language.FindKey("Buttons", "15").Value;
            this.lblCount.Text = Language.FindKey("Strings", "76").Value;
            this.lblNo.Text = Language.FindKey("Strings", "77").Value;
            this.grbValues.Text = Language.FindKey("Strings", "75").Value;
            this.grbWebs.Text = Language.FindKey("Strings", "97").Value;
            this.chkAll.Text = Language.FindKey("Strings", "46").Value;
            this.chkBudget.Text = Language.FindKey("Strings", "147").Value;
            this.chkProductionCompany.Text = Language.FindKey("Strings", "148").Value;
            this.chkPoster.Text = Language.FindKey("Strings", "154").Value;
            this.chkReleaseDate.Text = Language.FindKey("Strings", "155").Value;
        }
    }

    public partial class frmExcel
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "13").Value;
            btnFolderSelect.Text = Language.FindKey("Buttons", "31").Value;
            btnImport.Text = Language.FindKey("Buttons", "53").Value;
            labelControl1.Text = Language.FindKey("Strings", "1").Value;
            labelControl2.Text = Language.FindKey("Strings", "35").Value;
            labelControl4.Text = Language.FindKey("Strings", "36").Value;
        }
    }

    public partial class frmImportExport
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "7").Value;
            this.lblDatabase.Text = Language.FindKey("Strings", "54").Value;
            this.btnImport.Text = Language.FindKey("Buttons", "12").Value;
            this.btnCancel.Text = Language.FindKey("Buttons", "11").Value;
            this.lblCount.Text = Language.FindKey("Strings", "76").Value;
            this.lblNo.Text = Language.FindKey("Strings", "77").Value;
        }
    }

    public partial class frmSearchMovie
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "11").Value;
            this.btnSearch.Text = Language.FindKey("Buttons", "39").Value;
            this.btnOk.Text = Language.FindKey("Buttons", "10").Value;
            this.btnCancel.Text = Language.FindKey("Buttons", "11").Value;
        }
    }

    public partial class frmBackup
    {
        public void EmitLanguage()
        {
            lblStatus.Text = Language.FindKey("Messages", "2").Value;
        }
    }


    public partial class frmHistory
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "5").Value;
        }
    }

    public partial class frmAbout
    {
        public void EmitLanguage()
        {
            this.Text = Language.FindKey("Forms", "9").Value;
            lblVersion.Text = Language.FindKey("Strings", "104").Value;
            lblCopyright.Text = Language.FindKey("Strings", "105").Value;
            // lblEmail.Text = Language.FindKey("Strings", "106").Value;
            lblWeb.Text = Language.FindKey("Strings", "107").Value;
            tabAbout.Text = Language.FindKey("Strings", "108").Value;
            tabTranslations.Text = Language.FindKey("Strings", "109").Value;
           // btnPayPal.Text = Language.FindKey("Strings", "110").Value;
            lblLicanse.Text = Language.FindKey("Strings", "111").Value;
            lblLicanse2.Text = Language.FindKey("Strings", "112").Value;
        }
    }


    public partial class frmDatabaseUpdater
    {
        public void EmitLanguage()
        {
            lblStatus.Text = Language.FindKey("Strings", "136").Value;
        }
    }

    public partial class frmDatabaseRepair
    {
        public void EmitLanguage()
        {
            lblStatus.Text = Language.FindKey("Strings", "136").Value;
        }
    }
}



namespace GrieeX.UserControls
{
    public partial class MovieDetail
    {
        public void EmitLanguage()
        {
            this.tabMovieInfo.Text = Language.FindKey("Strings", "0").Value;
            this.lblOrginalName.Text = Language.FindKey("Strings", "1").Value;
            this.lblTurkishName.Text = Language.FindKey("Strings", "2").Value;
            this.lblDirector.Text = Language.FindKey("Strings", "3").Value;
            this.lblGenre.Text = Language.FindKey("Strings", "4").Value;
            this.lblWriter.Text = Language.FindKey("Strings", "5").Value;
            this.lblYear.Text = Language.FindKey("Strings", "6").Value;
            this.lblUserRating.Text = Language.FindKey("Strings", "7").Value;
            this.lblRuntime.Text = Language.FindKey("Strings", "8").Value;
            this.lblVotes.Text = Language.FindKey("Strings", "9").Value;
            this.lblLanguage.Text = Language.FindKey("Strings", "10").Value;
            this.lblCountry.Text = Language.FindKey("Strings", "11").Value;
            this.lblReleaseDate.Text = Language.FindKey("Strings", "155").Value;
            this.grbMovie.Text = Language.FindKey("Strings", "48").Value;
            this.cl1.Caption = Language.FindKey("Strings", "49").Value;
            this.cl2.Caption = Language.FindKey("Strings", "50").Value;
            this.tabEnglish.Text = Language.FindKey("Buttons", "26").Value;
            this.tabTurkish.Text = Language.FindKey("Buttons", "25").Value;

            this.rgMovieSeen.Properties.Items[0].Description = Language.FindKey("Strings", "13").Value;
            this.rgMovieSeen.Properties.Items[1].Description = Language.FindKey("Strings", "14").Value;

            this.tabFileInfo.Text = Language.FindKey("Strings", "15").Value;
            this.btnAdd.Text = Language.FindKey("Buttons", "0").Value;
            this.btnDelete.Text = Language.FindKey("Buttons", "3").Value;
            this.btnMultiAdd.Text = Language.FindKey("Buttons", "48").Value;

            this.tabOther.Text = Language.FindKey("Strings", "34").Value;
            this.lblImdbNumber.Text = Language.FindKey("Strings", "35").Value;
            this.lblArchivesNumber.Text = Language.FindKey("Strings", "36").Value;
            this.lblDateEntered22.Text = Language.FindKey("Strings", "37").Value;
            this.lblChangeDate22.Text = Language.FindKey("Strings", "38").Value;
            this.lblNote.Text = Language.FindKey("Strings", "42").Value;
            this.lblSubtitle.Text = Language.FindKey("Strings", "43").Value;
            this.lblDubbing.Text = Language.FindKey("Strings", "44").Value;
            this.lblPersonalRating.Text = Language.FindKey("Strings", "45").Value;
            this.lblUserColumn1.Text = Language.FindKey("Strings", "66").Value;
            this.lblUserColumn2.Text = Language.FindKey("Strings", "67").Value;
            this.lblUserColumn3.Text = Language.FindKey("Strings", "68").Value;
            this.lblUserColumn4.Text = Language.FindKey("Strings", "69").Value;
            this.lblUserColumn5.Text = Language.FindKey("Strings", "151").Value;
            this.lblUserColumn6.Text = Language.FindKey("Strings", "152").Value;
            this.lblRlsType.Text = Language.FindKey("Strings", "39").Value;
            this.lblRlsGroup.Text = Language.FindKey("Strings", "40").Value;
            this.lblBudget.Text = Language.FindKey("Strings", "147").Value;
            this.lblProductionCompany.Text = Language.FindKey("Strings", "148").Value;

            this.cl_FileName.Caption = Language.FindKey("Strings", "96").Value;

            this.mnuAdd.Text = Language.FindKey("Menu", "1").Value;
            this.mnuEdit.Text = Language.FindKey("Menu", "16").Value;
            this.mnuDelete.Text = Language.FindKey("Menu", "24").Value;
            this.mnuGoToImdbPage.Text = Language.FindKey("Menu", "17").Value;
            this.mnuSelectImage.Text = Language.FindKey("Menu", "18").Value;
            this.mnuDeleteImage.Text = Language.FindKey("Menu", "19").Value;

            this.cbSubTitle.Properties.SelectAllItemCaption = Language.FindKey("Buttons", "14").Value;
            this.cbDubbing.Properties.SelectAllItemCaption = Language.FindKey("Buttons", "14").Value;

        }
    }
}
