#include "calibrartionpage.h"
#include "ui_calibrartionpage.h"

#include "leg_animation_drawer.h"
#include "exercisecontroller.h"

#include <QDebug>
//#include "old_bl/cstreamcontrol.h"
//#include "blglue.h"

CalibrartionPage::CalibrartionPage(QWidget *parent) :
    MyParent( pgidSettingCalibration, parent),
    ui(new Ui::CalibrartionPage)
{
    ui->setupUi(this);

    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( DEFAULT_LEG_POS, 10, 10 );

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 16 );
}

CalibrartionPage::~CalibrartionPage()
{
    delete ui;
}

void CalibrartionPage::OnTimer()
{
    if( isVisible() )
    {
        quint8 top_level = 10;
        quint8 bottom_level = 10;
        if( CStreamControl::StreamHandlers.size() > 3 )
        {
            //Никита:
            //Сделать то же самое, как ты сделал на экране упражнения)
            //2->0
            top_level = GetLevelFromStreamHandler( 0 );
            bottom_level = GetLevelFromStreamHandler( 1 );
            //qDebug()<<"top:"<<top_level<<"bottom:"<<bottom_level;
        }
        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( DEFAULT_LEG_POS, top_level, bottom_level );
    }
}

void CalibrartionPage::OnCalibrationTimer()
{
    Log( "Обновлена калибровка" );
    qDebug()<<"Обновлена калибровка";
    LockCalibrationControl( false );


    auto p = BlGlue::Instance().Core().m_KProxyPtr;
    disconnect( p, SIGNAL( Calibrated() ), this, SLOT(OnCalibrationTimer()) );
    //CStreamControl::CalcCalibrationMask( mCalibrationConfig, 10000, QString());
    //BlGlue::Instance().Core().WriteSettings();
}

void CalibrartionPage::on_pushButton_calibrate_clicked()
{
    Log( "Старт калибровки" );
    /*std::set<std::pair<int, double> > config;
    config.insert(std::pair<int, double>( 0, CStreamControl::nEnergyFilterCoefficient[0] ));
    config.insert(std::pair<int, double>( 1, CStreamControl::nEnergyFilterCoefficient[1] ));
    config.insert(std::pair<int, double>( 2, CStreamControl::nEnergyFilterCoefficient[2] ));
    config.insert(std::pair<int, double>( 3, CStreamControl::nEnergyFilterCoefficient[3] ));
    mCalibrationConfig = config;
    LockCalibrationControl( true );
    QTimer::singleShot( 5000 ,this,SLOT(OnCalibrationTimer()));*/
    LockCalibrationControl( true );
    BlGlue::Instance().Core().m_KProxyPtr->Calibrate();


    auto p = BlGlue::Instance().Core().m_KProxyPtr;
    connect( p, SIGNAL( Calibrated() ), this, SLOT(OnCalibrationTimer()) );
}

void CalibrartionPage::LockCalibrationControl( bool lock )
{
    bool enable = !lock;
    ui->pushButton_calibrate->setEnabled( enable );
    ui->pushButton_forward->setEnabled( enable );
    ui->pushButton_cancel->setEnabled( enable );
}
