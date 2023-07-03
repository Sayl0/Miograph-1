#include "leg_animation_drawer.h"
#include <QDirIterator>
#include <QDebug>
#include <QPainter>

LegAnimationDrawer::LegAnimationDrawer(QObject *parent)
    :QObject( parent )
{

}

LegAnimationDrawer &LegAnimationDrawer::Instance()
{
    static LegAnimationDrawer instance( nullptr );
    return instance;
}

void LegAnimationDrawer::SetLabel( QLabel *label )
{
    mLabel = label;
    LoadImages();
}

void LoadImgVect( std::vector<QImage>& vect, const QString& path, QSize sz )
{
    vect.clear();
    QDir dir( path );

    auto list = dir.entryList(QDir::Files, QDir::Name);
    for( auto& file : list )
    {
        QString full_path = path + file;
        vect.emplace_back( QImage( full_path, "PNG" ));
//        vect.emplace_back( QImage( full_path, "PNG" ).scaled( sz.width(), sz.height(), Qt::IgnoreAspectRatio, Qt::SmoothTransformation ));
//        vect.back().save(QDir::currentPath() +"/"+ full_path.mid(2));
        qDebug()<<"path"<<full_path<<QDir::currentPath() + full_path.mid(2);
    }
}

void LegAnimationDrawer::LoadImages()
{
    if( !mMainImg.empty() )
        return;
    LoadImgVect( mMainImg, ":\\leg_img\\main_img\\", mLabel->size() );
    LoadImgVect( mLowImg, ":\\leg_img\\low_img\\", mLabel->size()  );
    LoadImgVect( mTopImg, ":\\leg_img\\up_img\\", mLabel->size()  );
    qDebug()<<"Img sizes:"<<mMainImg.size()<<mLowImg.size()<<mTopImg.size();
}

void LegAnimationDrawer::Draw(quint8 pos, quint8 top, quint8 bottom)
{
    if( mLabel == nullptr )
        return;

    if( pos > 99 )
        pos = 99;

    //pos = 99 - pos;

    pos = pos / 2;

    QImage img = mMainImg[pos];

    QPainter p(&img);
    p.setCompositionMode( QPainter::CompositionMode_SourceOver );
    p.setPen(Qt::NoPen);
    p.setRenderHint( QPainter::SmoothPixmapTransform );

    //QImage scaled_t = mTopImg[pos].scaled( mLabel->size().width(), mLabel->size().height());
    p.setOpacity( qreal(top) / 50 );
    p.drawImage( 0, 0, mTopImg[pos] );

    //QImage scaled_b = mLowImg[pos].scaled( mLabel->size().width(), mLabel->size().height() );
    p.setOpacity( qreal(bottom) / 50 );
    p.drawImage( 0, 0, mLowImg[pos] );

    mLabel->setPixmap( QPixmap::fromImage( img,  Qt::DiffuseDither) );
}

