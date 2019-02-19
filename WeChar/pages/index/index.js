//index.js
Page({
  data: {
    //轮播图
    imgUrls: [
      '../../image/lun1.png',
      '../../image/lun2.png',
      '../../image/lun3.png',
      '../../image/lun4.png',
      '../../image/lun5.png',
      '../../image/lun6.png'
    ],
    indicatorDots: true,
    interval: 5000,
    duration: 1000
  },
  onLoad: function() {
    var that = this;
    wx.request({
      url: 'http://localhost:56603/api/Index/GetIndexNews',
      method:'GET',
      success: function (res) {
        that.setData({
          indexNews: res.data        
        })         
      }
    })
  }
})