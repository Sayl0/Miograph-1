#ifndef LEG_ANIMATION_DRAWER_H
#define LEG_ANIMATION_DRAWER_H

#include <QObject>
#include <QLabel>
#include <QTimer>
#include <QImage>

class LegAnimationDrawer : public QObject
{
public:
    static LegAnimationDrawer& Instance();

    void SetLabel( QLabel* label );

    void SetPos( quint8 pos );

    void Draw( quint8 pos, quint8 top, quint8 bottom );

private:

    QLabel* mLabel = nullptr;

    std::vector<QImage> mMainImg;
    std::vector<QImage> mLowImg;
    std::vector<QImage> mTopImg;


    LegAnimationDrawer( QObject *parent = nullptr );

    void LoadImages();

};

#endif // LEG_ANIMATION_DRAWER_H
