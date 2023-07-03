#include "ui/startpage.h"
#include "ui_startpage.h"

#include "blglue.h"

#include "helpbrowser.h"

StartPage::StartPage(QWidget *parent) :
    BasePage( pgidStart, parent ),
    ui(new Ui::StartPage)
{
    ui->setupUi(this);

    BlGlue::Instance().ConnectionStart();

    QString err_str;
    BlGlue::Instance().OpenServoConnection( err_str );

}

StartPage::~StartPage()
{
    delete ui;
}

void StartPage::on_pushButton_fast_start_clicked()
{
    BlGlue::Instance().ResetLog();
    MoveToPage(pgidModeSelection);
    Log( "Начать сессию" );

}


void StartPage::on_pushButton_select_user_clicked()
{
    MoveToPage( pgidSelectUser, Page() );
}


void StartPage::on_pushButton_users_manual_clicked()
{
    MoveToPage(pgidShowHelp);
    /*
    QHelpEngine* helpEngine = new QHelpEngine(
                    QApplication::applicationDirPath() +
                    "um_collection.qhc");
        helpEngine->setupData();

        QTabWidget* tWidget = new QTabWidget;
        tWidget->setMaximumWidth(200);
        tWidget->addTab(helpEngine->contentWidget(), "Contents");
        tWidget->addTab(helpEngine->indexWidget(), "Index");

        HelpBrowser *textViewer = new HelpBrowser(helpEngine);
        textViewer->setSource(
                    QUrl("qthelp://miograph.ru.miohelp/index.html"));
        connect(helpEngine->contentWidget(),
                SIGNAL(linkActivated(QUrl)),
                textViewer, SLOT(setSource(QUrl)));

        connect(helpEngine->indexWidget(),
                SIGNAL(linkActivated(QUrl, QString)),
                textViewer, SLOT(setSource(QUrl)));

        QSplitter *horizSplitter = new QSplitter(Qt::Horizontal);
        horizSplitter->insertWidget(0, tWidget);
        horizSplitter->insertWidget(1, textViewer);
        horizSplitter->hide();

        helpWindow = new QDockWidget(tr("Help"), this);
        helpWindow->setWidget(horizSplitter);
        helpWindow->hide();

        addDockWidget(Qt::BottomDockWidgetArea, helpWindow);
    */
}


void StartPage::on_pushButton_exit_clicked()
{
    Log( "Выход" );
    QApplication::quit();
}

