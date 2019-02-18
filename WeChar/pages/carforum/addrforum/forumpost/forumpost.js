// pages/carforum/brandforum/brandforuminfo/forumcontent/forumcontent.js
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
      Title: options.posttitle,
      forumid:options.id
    })
 
  var that=this;
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumLists?Id=' + options.id,
      method: 'GET',
      data: {},
      success: function (data) {
        console.log(data.PostTitle)
        that.setData({
          postcontent: data.data,
         
        })
      }
    });
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumReplyList?addrForumId=' + options.id,
      method: 'GET',
      data: {},
      success: function (data) {
        that.setData({
          getansers: data.data,

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
  replies:function(event){
    var that=this;
    var repliescontent = event.detail.value.repliescontent;
   
    var AddrForumid = event.currentTarget.dataset.addrforumid;
      wx.request({
        url: 'http://localhost:56603/api/AddrForumIndex/AddReply',
        method: 'POST',
        data: {
          AddrForumID: AddrForumid,
          AnserContent: repliescontent
        },
        success: function (data) {
          wx.showToast({
            title: '回复成功!'
            
          })
          that.onLoad();  
            
        }
      })
    }
  
 
})