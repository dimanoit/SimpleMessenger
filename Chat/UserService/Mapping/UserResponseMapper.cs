﻿using Chat.Db.Entities;
using Chat.User.Model;

namespace Chat.User.Mapping
{
    public static class UserResponseMapper
    {
        public static UserResponse ToUserResponse(this Db.Entities.User entity)
        {
            return new UserResponse()
            {
                Id = entity.Id,
                Role = entity.Role,
                Token = entity.Token,
                Username = entity.Username
            };
        }
    }
}
