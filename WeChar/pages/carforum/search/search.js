// pages/carforum/search/search.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    title: "汽车之家查询",
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      serechTitle: options.postTitle
    })
    var that = this;
    if()
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumListsByName',
      method: 'GET',
      data: { forumName:options.postTitle},
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/AddrForumIndex/GetReplyNum?addrForumId=' + data.AddrId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              addransernum: res.data
            })
          }
        })

      }
    });
   
    wx.request({
      url: 'http://localhost:56603/api/BrandForumIndex/GetBrandForumListsByName',
      method: 'GET',
      data: { forumName: options.postTitle },
      success: function (data) {
        that.setData({
          brandpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/BrandForumIndex/GetReplyNum?brandForumId=' + data.BrandId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              addransernum: res.data
            })
          }
        })
      }
    });
    
    wx.request({
      url: 'http://localhost:56603/api/HotForumIndex/GetHotForumListsByName',
      method: 'GET',
      data: { forumName: options.postTitle },
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/HotForumIndex/GetReplyNum?hotForumId=' + data.Hotid,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              hotansernum: res.data
            })
          }
        })
      }
    });
  
    wx.request({
      url: 'http://localhost:56603/api/ThemeForumIndex/GetThemeForumListsByName',
      method: 'GET',
      data: { forumName: options.postTitle },
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/ThemeForumIndex/GetReplyNum?themeForumId=' + data.ThemeId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              themeansernum: res.data
            })
          }
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
  //搜索功能
  searchTitle: function (event) {
    var that = this;
    var postTitle = event.detail.value.postTitle;
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumListsByName',
      method: 'GET',
      data: { forumName: postTitle },
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/AddrForumIndex/GetReplyNum?addrForumId=' + data.AddrId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              addransernum: res.data
            })
          }
        })

      }
    });

    wx.request({
      url: 'http://localhost:56603/api/BrandForumIndex/GetBrandForumListsByName',
      method: 'GET',
      data: { forumName:postTitle },
      success: function (data) {
        that.setData({
          brandpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/BrandForumIndex/GetReplyNum?brandForumId=' + data.BrandId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              addransernum: res.data
            })
          }
        })
      }
    });

    wx.request({
      url: 'http://localhost:56603/api/HotForumIndex/GetHotForumListsByName',
      method: 'GET',
      data: { forumName: postTitle },
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/HotForumIndex/GetReplyNum?hotForumId=' + data.Hotid,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              hotansernum: res.data
            })
          }
        })
      }
    });

    wx.request({
      url: 'http://localhost:56603/api/ThemeForumIndex/GetThemeForumListsByName',
      method: 'GET',
      data: { forumName: postTitle },
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
        wx.request({
          url: 'http://localhost:56603/api/ThemeForumIndex/GetReplyNum?themeForumId=' + data.ThemeId,
          method: 'GET',
          success: function (res) {
            console.log(res.data);
            that.setData({
              themeansernum: res.data
            })
          }
        })
      }
    });
  },
  //看帖
  intoaddr: function (e) {
    var addrposttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/addrforum/forumpost/forumpost?posttitle=' + addrposttitle + '&id=' + id,
    })
  },
  intobrand: function (e) {
    var brandposttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/brandforum/forumpost/forumpost?posttitle=' + brandposttitle + '&id=' + id,
    })
  },
  intohot: function (e) {
    var hotposttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/hotforum/forumpost/forumpost?posttitle=' + hotposttitle + '&id=' + id,
    })
  },
  intotheme: function (e) {
    var themeposttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/themeforum/forumpost/forumpost?posttitle=' + themeposttitle + '&id=' + id,
    })
  },
})