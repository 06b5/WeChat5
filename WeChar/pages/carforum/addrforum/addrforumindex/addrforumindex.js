// pages/carforum/addrforum/addrforum.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    title:'地区',
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
     var that=this;
     
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/AddrLists',
      method:'GET',
      success:function(data)
      {
        console.log(data.data)
        that.setData({
          addr:data.data
        })
      }
    })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },
  toaddrforum:function(e){
    var addrname = e.currentTarget.dataset.addrname;
    var id = e.currentTarget.dataset.id;
    console.log(addrname);
    wx.navigateTo({
      url: '/pages/carforum/addrforum/addrforuminfo/addrforuminfo?addrname=' + addrname + '&id=' + id,
    })
  }
})