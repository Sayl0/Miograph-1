#include "diagnosisanklemobstrpage.h"
#include "ui_diagnosisanklemobstrpage.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include "exercisecontroller.h"

DiagnosisAnkleMobStrPage::DiagnosisAnkleMobStrPage(QWidget *parent) :
    BasePage(pgidDiagnosisAnkleMobStr, parent),
    ui(new Ui::DiagnosisAnkleMobStrPage)
{
    ui->setupUi(this);
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( 0, 0, 0 );

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
}

DiagnosisAnkleMobStrPage::~DiagnosisAnkleMobStrPage()
{
    delete ui;
}

void DiagnosisAnkleMobStrPage::OnTimer()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        // не нужен здесь угол
        //ui->label_angle->setText( QString::number( AngleFromPos( pos ) ) + "°" );

        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
        qDebug()<<"LegBendMeasurePage::OnTimer"<<"Pos"<<pos;
    }
}

void DiagnosisAnkleMobStrPage::hideEvent(QHideEvent * e)
{
    auto config = ExerciseController::Instance().Settings();
    quint16 pos = ExerciseController::Instance().Pos();
    config.mMaxFlexAngle = AngleFromPos( pos );
    ExerciseController::Instance().SetExerciseConfig( config );
    Log( "Exercise angle:" + QString::number( config.mMaxFlexAngle ) );

    MyParent::hideEvent( e );
}

void DiagnosisAnkleMobStrPage::showEvent(QShowEvent */*e*/)
{
    OnTimer();
}



void DiagnosisAnkleMobStrPage::on_lineEdit_flexion_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mD2 = arg1.toFloat() / 100;
}


void DiagnosisAnkleMobStrPage::on_lineEdit_tenzo_error_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mDeviation = arg1.toFloat() / 100;
}


void DiagnosisAnkleMobStrPage::on_lineEdit_extension_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mD1 = arg1.toFloat() / 100;
}

