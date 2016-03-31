package cc.zeben.zjculture.pager;

import org.apache.commons.collections4.CollectionUtils;

import java.util.List;

/**
 * 泽本信息版权所有 2014-2015
 * 创建者：，张先利
 * 创建于：2015/10/5，16:39.
 * 项目名称：powerms
 * 修订记录：
 * 当前版本：1.0
 * 功能描述：
 */
public class Pager<T> {
    //内存数据列表
    private List<T> objs = null;
    //每页大小
    private int pageSize = 10;
    //总页数
    private int pageCount = 1;
    //当前页码
    private int pageNum = 1;


    public Pager(final List<T> objs, final int pageSize) {
        this.pageSize = pageSize;
        this.objs = objs;
        if (!CollectionUtils.isEmpty(this.objs)) {
            //向上取整数
            this.pageCount = (new Float(Math.ceil((float) this.objs.size() / this.pageSize)).intValue());
        }
    }


    public List<T> getPage(Integer pageNum) {
        if (pageNum == null || pageNum > this.pageCount || pageNum < 1) {
            this.pageNum = 1;
        } else {
            this.pageNum = pageNum;
        }

        if (!CollectionUtils.isEmpty(this.objs)) {
            int start = (this.pageNum - 1) * this.pageSize;
            int end = this.pageNum * this.pageSize;
            if (end > this.objs.size()) {
                end = this.objs.size();
            }

            return this.objs.subList(start, end);
        }

        return null;
    }


    public int getPageSize() {
        return pageSize;
    }

    public void setPageSize(int pageSize) {
        this.pageSize = pageSize;
    }

    public int getPageCount() {
        return pageCount;
    }

    public void setPageCount(int pageCount) {
        this.pageCount = pageCount;
    }

    public int getPageNum() {
        return pageNum;
    }

    public void setPageNum(int pageNum) {
        this.pageNum = pageNum;
    }
}

