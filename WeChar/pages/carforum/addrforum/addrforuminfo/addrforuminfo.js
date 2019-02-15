// pages/carforum/brandforum/brandforuminfo/brandforuminfo.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
    
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      addrname: options.addrname +"论坛",
    });
   var that=this;
   wx.request({
     url: 'http://localhost:56603/api/AddrForumIndex/AddrForumPosts?AddrId=' + options.id,
     method:'GET',
     data: {},
     success:function(data){
       that.setData({
         postlist:data.data
       })
     }
   });
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/AnserNum?AddrForumId=' + options.id,
      method: 'GET',
      success: function (res) {
        console.log(res.data);
        that.setData({
          ansernum: res.data
        })
      }
    });
   
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
  into:function(e){
    var posttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/addrforum/forumpost/forumpost?posttitle=' + posttitle +'&id='+id,
    })
  },
   fatie(event) {
     var addrid = event.currentTarget.dataset.addrid;
    wx.navigateTo({
      url: '/pages/carforum/addrforum/posting/posting?addrid=' + addrid,
    })
  },
})