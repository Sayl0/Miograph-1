#include "showhelppage.h"
#include "ui_showhelppage.h"
#include "helpbrowser.h"

ShowHelpPage::ShowHelpPage(QWidget *parent) :
    BasePage(pgidShowHelp,parent),
    ui(new Ui::ShowHelpPage)
{
    ui->setupUi(this);
    SetupHelpWindow();
}

ShowHelpPage::~ShowHelpPage()
{
    delete ui;
}

void ShowHelpPage::SetupHelpWindow()
{
    //QHelpEngine* helpEngine = new QHelpEngine( QApplication::applicationDirPath() +
    //            "um_collection.qhc");
    //helpEngine->setupData();
    //HelpBrowser *textbBrowserHelp = new HelpBrowser(helpEngine);

    //QMessageBox::warning(this, "Сообщение","Вроде бы setupData успешен!");

    //ui->textBrowserHelp->setSource(QUrl("file:///C:/work/miograph/documentation/index.html"));
    //ui->textBrowserHelp->setSource(QUrl("file:///documentation/index.html"));

    QString path=QApplication::applicationDirPath()+"/documentation/index.html";
    ui->textBrowserHelp->setSource(QUrl(QUrl::fromLocalFile(path)));
    ui->textBrowserHelp->show();

    //ui->textBrowserHelp->
}

void ShowHelpPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidStart);
}



